using ALMUSIC_APP.controlador.persistencia;
using Id3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Threading;
using System.Drawing;
using ALMUSIC_APP.controlador.logica;
using NAudio.Wave;


namespace ALMUSIC_APP.controlador
{

    public class GestionMusica : IGestionTiempo<GestionMusica>
    {
        private Musica musica;
        private List<Musica> canciones;
        private MusicaArchivo musicaArchivo;
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;

        private Thread hilo;
        internal bool siguiente { get; set; }

        public int SEGUNDOS
        {
            get
            {
                return 1;
            }
        }

        public int MINUTOS
        {
            get
            {
                return (this.SEGUNDOS) * 60;
            }
        }

        public int MILISEGUNDOS
        {
            get
            {
                return (this.SEGUNDOS) * 1000;
            }
        }

        public int HORAS
        {
            get
            {
                return (this.MINUTOS) * 60;
            }
        }

        public GestionMusica() {
            musica = null;
            
            canciones = new List<Musica>();
            musicaArchivo = new MusicaArchivo("canciones.bin");
            obtenerTodoslosDatos();
            siguiente = false;
        }

        private void obtenerTodoslosDatos()
        {
            canciones = musicaArchivo.obtenerTodosLosDatos();
        }

        public Musica agregarCancion(String extensionArchivoCancion, String rutaDeLaCancion, string rutaDeCarpeta) {
            musica = new Musica(extensionArchivoCancion, rutaDeLaCancion, rutaDeCarpeta);
            agregarEtiquetas(rutaDeLaCancion);
            canciones.Add(musica);
            musicaArchivo.ingresarDato(musica);
            return musica;

        }

        internal Musica obtenerCancionPorID(int i)
        {
            return this.canciones.ElementAt(i);
        }

        public bool listaMusicaVacia()
        {
            return canciones.Count > 0;
        }

        public void agregarEtiquetas(String ruta) {
            try
            {
                string usuario = System.Environment.UserName;
                AddFileSecurity(ruta, usuario,FileSystemRights.ReadData, AccessControlType.Allow);
                var f = new FileIOPermission(PermissionState.None);
                f.AddPathList(FileIOPermissionAccess.AllAccess, ruta);

                f.Demand();
                var mp3 = new Mp3File(ruta, Mp3Permissions.ReadWrite);
                bool hasTags = mp3.HasTags;

                if (mp3.HasTags)
                {
                    Id3Tag[] datos = mp3.GetAllTags();
                    if (datos[0].Title != null)
                    {
                        musica.setTitulo(datos[0].Title);
                    }
                    else {
                        musica.setTitulo("Desconocido");
                    }

                    if (datos[0].Artists != null)
                    {
                        musica.setArtista(datos[0].Artists);
                    }
                    else {
                        musica.setArtista("Desconocido");
                    }

                    if (datos[0].Album != null)
                    {
                        musica.setAlbum(datos[0].Album);
                    }
                    else {
                        musica.setAlbum("Desconocido");
                    }

                    if (datos[0].Genre != null)
                    {
                        musica.setGenero(datos[0].Genre);
                    }
                    else {
                        musica.setGenero("Desconocido");
                    }

                    if (datos[0].Year != null)
                    {
                        musica.setAnioPublicacion(datos[0].Year);
                    }
                    else {
                        musica.setAnioPublicacion("Desconocido");
                    }

                    if (datos[0].BeatsPerMinute.Value > 0)
                    {
                        musica.setBMP(datos[0].BeatsPerMinute.Value.Value);
                    }
                    else {
                        musica.setBMP(0);
                    }

                    musica.setRutaDeLaCancion(ruta);
                }


                mp3.Dispose();
                if (hasTags)
                {
                    TagLib.File file = TagLib.File.Create(ruta);
                    if (file.Tag.Pictures.Length >= 1)
                    {
                        var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                        musica.setDatosBinarios(bin);
                    }

                    if (file.Properties.Duration.Milliseconds > 0)
                    {
                        //Console.WriteLine(file.Properties.Duration.ToString());
                        musica.setDuracionCancion(file.Properties.Duration.Milliseconds);

                    }

                    if ((file.Properties.AudioBitrate > 0) && (musica.getBMP() > 0))
                    {
                        musica.setBMP(file.Properties.AudioBitrate);
                    }

                    file.Dispose();
                }
                //Thread.Sleep(60);
            }
            catch (System.NotSupportedException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (UnauthorizedAccessException x)
            {
                //Console.WriteLine("Hola " + ruta);
                extraerEtiquetas(ruta);
                
            }
            catch (SecurityException xe) {
                Console.WriteLine(xe.StackTrace);
            }
        }

        internal List<Musica> obtenerTodasLasCanciones()
        {
            return this.canciones;
        }

        internal Image obtenerImagenAlbum(string ruta)
        {
            MemoryStream ms;
            foreach (Musica m in canciones)
            {

                if (m.getRutaDeLaCancion().Equals(ruta)) {
                    if (m.getDatosBinarios() != null)
                    {
                        ms = new MemoryStream(m.getDatosBinarios());

                        return Image.FromStream(ms);
                    }
                }
            }

            return null;
        }

        internal void ingresarVolumen(float volumen)
        {
            //wplayer.settings.volume = volumen;
            waveOutDevice.Volume = volumen;

        }

        internal void iniciarHiloReproduccion(string ruta)
        {
            cerrarTodoEnReproduccion();
            hilo = new Thread(new ParameterizedThreadStart(reproducirCancion));
            hilo.Start(ruta);
        }

        private void cerrarTodoEnReproduccion() {
            if (hilo != null)
            {
                hilo.Abort();
                hilo = null;
                if (waveOutDevice != null)
                {
                    waveOutDevice.Dispose();
                    waveOutDevice.Stop();
                }
                
                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                    audioFileReader.Close();
                }
                
                

            }
        }

        internal unsafe string[,] buscarCancionPorArtista(int *cantidad, String artista)
        {
            //Cuantas canciones de ese artista hay?

            for(int i = 0; i < this.obtenerCantidadDeCanciones(); i++)
            {
                Musica m = this.canciones.ElementAt(i);
                if (m.getArtista() != null)
                {
                    if (m.getArtista().Equals(artista))
                    {
                        Console.WriteLine(m.getArtista());
                        *cantidad = *cantidad + 1;
                    }
                }
            }
            //Cargar musica del artista
            //i = Controla la lista de canciones
            //j = controla el index de filas de la matriz
            string[,] cancionesArt = new string[*cantidad, 6];
            for(int i = 0, j = 0; i < *cantidad; i++)
            {
                Musica m = this.canciones.ElementAt(i);
                if (m.getArtista() != null)
                {
                    if (m.getArtista().Equals(artista))
                    {
                        cancionesArt[j,0] = m.getArtista();
                        if (m.getTitulo() != null)
                        {
                            cancionesArt[j, 1] = m.getTitulo();
                        }
                        else
                        {
                            cancionesArt[j, 1] = "Desconocido";
                        }

                        if (m.getAlbum() != null)
                        {
                            cancionesArt[j, 2] = m.getAlbum();
                        }
                        else
                        {
                            cancionesArt[j, 2] = "Desconocido";
                        }

                        if (m.getDuracionCancion() > 0)
                        {
                            cancionesArt[j, 3] = m.getDuracionCancion() + "";
                        }

                        if (m.getAnioPublicacion() != null)
                        {
                            cancionesArt[j, 4] = m.getAnioPublicacion();
                        }
                        else
                        {
                            cancionesArt[j, 4] = "Desconocido";
                        }

                        if (m.getRutaDeLaCancion() != null)
                        {
                            cancionesArt[j, 5] = m.getRutaDeLaCancion();
                        }
                        j++;
                    }
                }
            }

            /*for(int k = 0; k < *cantidad; k++)
            {
                for(int j = 0; j < 6; j++)
                {
                    Console.Write(cancionesArt[k, j] + " \n");
                }
            }*/

            /*for(int i = 0; i < this.obtenerCantidadDeCanciones(); i++)
            {
                Musica m = this.canciones.ElementAt(i);
                Console.WriteLine(m.getArtista() + " " + m.getTitulo() + "\n");
            }*/
            return cancionesArt;

        }

        internal void iniciarHiloStreaming(Object url)
        {
            cerrarTodoEnReproduccion();
            hilo = new Thread(new ParameterizedThreadStart(reproducirCancion));
            hilo.Start(url);
        }

        private void reproducirStreaming(string url) {
            using (Stream ms = new MemoryStream())
            {
                using (Stream stream = WebRequest.Create(url)
                    .GetResponse().GetResponseStream())
                {
                    byte[] buffer = new byte[32768];
                    int read;
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                }

                ms.Position = 0;
                using (WaveStream blockAlignedStream =
                    new BlockAlignReductionStream(
                        WaveFormatConversionStream.CreatePcmStream(
                            new Mp3FileReader(ms))))
                {
                    using (WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        waveOut.Init(blockAlignedStream);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
        }

        private void reproducirCancion(Object ruta) {
            
            if (ruta != null)
            {
                if (!ruta.Equals(""))
                {
                    siguiente = false;
                    //Console.WriteLine(this.canciones.ElementAt(0).getRutaDeLaCancion());
                    audioFileReader = new AudioFileReader((String)ruta);
                    waveOutDevice = new WaveOut(WaveCallbackInfo.FunctionCallback());
                    this.waveOutDevice.PlaybackStopped += new EventHandler<StoppedEventArgs>(this.Player_PlayStateChange);

                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                }
            }
            
            
        }

        private void Player_PlayStateChange(object sender, EventArgs e)
        {

            /*f ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                wplayer.close();
                siguiente = true;
            }*/
            if (waveOutDevice.PlaybackState == PlaybackState.Stopped)
            {
                waveOutDevice.Stop();
                audioFileReader.Dispose();
                audioFileReader.Close();
                siguiente = true;
            }

        }

        private void Player_MediaError(object pMediaObject)
        {
            //MessageBox.Show("Cannot play media file.");
            //wplayer.close();
            hilo.Abort();
        }

        internal string[] obtenerInfoCancionesPorID(int i)
        {
            string[] infoCanciones = new string[6];
            Musica m = this.canciones.ElementAt(i);
            if (m.getArtista() != null) {
                infoCanciones[0] = m.getArtista();
            } else
            {
                infoCanciones[0] = "Desconocido";
            }
            
            if(m.getTitulo() != null)
            {
                infoCanciones[1] = m.getTitulo();
            } else
            {
                infoCanciones[1] = "Desconocido";
            }
            
            if(m.getAlbum() != null)
            {
                infoCanciones[2] = m.getAlbum();
            } else
            {
                infoCanciones[2] = "Desconocido";
            }

            if(m.getDuracionCancion() > 0)
            {
                infoCanciones[3] = m.getDuracionCancion() + "";
            }
            
            if(m.getAnioPublicacion() != null)
            {
                infoCanciones[4] = m.getAnioPublicacion();
            } else
            {
                infoCanciones[4] = "Desconocido";
            }
            
            if(m.getRutaDeLaCancion() != null)
            {
                infoCanciones[5] = m.getRutaDeLaCancion();
            }

            return infoCanciones;
            
        }

        internal byte[] obtenerImagenesCaratula()
        {
            return this.canciones.ElementAt(400).getDatosBinarios();
        }

        internal string[,] agregarCancionesALista(int columnCount, int rowCount)
        {

            try {
                string[,] canciones = new string[this.canciones.Count, columnCount];
                for (int i = 0; i < this.canciones.Count; i++)
                {
                    Musica m = this.canciones.ElementAt(i);
                    for (int j = 0; j < columnCount; j++)
                    {
                        canciones[i, j] = m.getTitulo() + " " + m.getArtista();
                    }
                }
                return canciones;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.StackTrace);
                return new string[canciones.Count,columnCount];
            }
        }

        private void extraerEtiquetas(String ruta)
        {
            try
            {
                TagLib.File file = TagLib.File.Create(ruta);
                if (file.Tag.Album != null)
                {
                    musica.setAlbum(file.Tag.Album);
                }
                else {
                    musica.setAlbum("Desconocido");
                }

                if (file.Tag.Genres[0] != null) {
                    musica.setGenero(file.Tag.Genres[0]);
                } else {
                    musica.setGenero("Desconocido");
                }

                if (file.Tag.Title != null)
                {
                    musica.setTitulo(file.Tag.Title);
                }
                else {
                    musica.setTitulo("Desconocido");
                }

                if (file.Tag.Year > 0)
                {
                    musica.setAnioPublicacion(Convert.ToInt32(file.Tag.Year) + "");
                }
                else {
                    musica.setAnioPublicacion("Desconocido");
                }

                /*if (file.Tag.AlbumArtists != null) {
                    string artista = null;
                    musica.setArtista(file.Tag.AlbumArtists[0]);
                } else
                {
                    musica.setArtista("Desconocido");
                }*/

                if (file.Tag.Pictures.Length >= 1)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    musica.setDatosBinarios(bin);
                }
                musica.setRutaDeLaCancion(ruta);
                file.Dispose();

            }
            catch (UnauthorizedAccessException e) {
                Console.WriteLine("Holax2 " + ruta);
            }catch(IndexOutOfRangeException h)
            {
                Console.WriteLine(h.StackTrace);

            }
            
        }

        public static void AddFileSecurity(string fileName, string account,
        FileSystemRights rights, AccessControlType controlType)
        {


            // Get a FileSecurity object that represents the
            // current security settings.
            FileSecurity fSecurity = File.GetAccessControl(fileName);

            // Add the FileSystemAccessRule to the security settings.
            fSecurity.AddAccessRule(new FileSystemAccessRule(account,
            rights, controlType));//parecido es para remove

            // Set the new access settings.
            File.SetAccessControl(fileName, fSecurity);

        }

        // Removes an ACL entry on the specified file for the specified account.
        public static void RemoveFileSecurity(string fileName, string account,
        FileSystemRights rights, AccessControlType controlType)
        {

            // Get a FileSecurity object that represents the
            // current security settings.
            FileSecurity fSecurity = File.GetAccessControl(fileName);

            // Remove the FileSystemAccessRule from the security settings.
            fSecurity.RemoveAccessRule(new FileSystemAccessRule(account,
            rights, controlType));

            // Set the new access settings.
            File.SetAccessControl(fileName, fSecurity);

        }

        public int obtenerCantidadDeCanciones() {
            return this.canciones.Count;
        }

        internal bool estaHiloMusicaVivo() {
            return this.hilo.IsAlive;
        }

        internal double obtenerSegundosActualesCancion() {
            try
            {
                return this.audioFileReader.CurrentTime.TotalSeconds;
            }
            catch(NullReferenceException ex)
            {
                return 0D;
            }
            
            
        }

        internal long obtenerSegundosTotalesCancion(string rutaID) {
            foreach(Musica m in canciones)
            {
                if (m.getRutaDeLaCancion().Equals(rutaID)) {
                    return m.getDuracionCancion();
                }
            }
            return 0L;
        }

        internal void pausarMusica() {
            //this.wplayer.controls.pause();
            this.waveOutDevice.Pause();
        }

        internal void reanudarMusica() {
            //this.wplayer.controls.play();

            this.waveOutDevice.Play();
        }

        internal void pararCancion() {
            /*this.wplayer.controls.stop();
            wplayer.close();*/
            if (hilo != null)
            {
                this.waveOutDevice.Stop();
                this.audioFileReader.Close();
                this.hilo.Abort();
                hilo = null;
            }
            
            
        }

        public string obtenerDuracionActualCancion()
        {
            try
            {
                if(audioFileReader != null && this.audioFileReader.CurrentTime != null)
                {
                    int segundos = (int)this.audioFileReader.CurrentTime.TotalSeconds;
                    int hor = (int)(segundos / (60 * 60));
                    int min = (int)((segundos - (hor * 60 * 60)) / 60);
                    int seg = (int)(segundos - (hor * 60 * 60) - (min * 60));
                    if (hor == 0)
                    {
                        if (seg <= 9)
                        {
                            return min + ":" + "0" + seg;
                        }
                        else
                        {
                            return min + ":" + seg;
                        }

                    }
                    else
                    {
                        if (seg <= 9)
                        {
                            return hor + ":" + min + ":" + "0" + seg;
                        }
                        else
                        {
                            return hor + ":" + min + ":" + seg;
                        }
                    }
                }
                return "0:00";
            }
            catch (COMException e)
            {
                return "0:00";
            }
            catch(NullReferenceException ex)
            {
                return "0:00";
            }
        }
    }

}
