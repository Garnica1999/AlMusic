using ALMUSIC_APP.modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.controlador.persistencia
{
    public class VideoArchivo
    {
        private IFormatter formatter;
        private Stream stream;
        private string nombre;
        public VideoArchivo(string nombre)
        {
            this.nombre = nombre;
            crearArchivo();
        }

        private void crearArchivo()
        {
            if (!File.Exists(nombre))
            {
                File.Create(nombre);
            }
        }

        public void eliminarArchivo()
        {
            if (File.Exists(nombre))
            {
                File.Delete(nombre);
            }
        }

        public bool ingresarDato(Video video)
        {
            try
            {
                formatter = new BinaryFormatter();
                stream = File.Open(nombre, FileMode.Append, FileAccess.Write);
                formatter.Serialize(stream, video);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                stream.Close();
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            catch (SecurityException s)
            {
                stream.Close();
                return false;
            }
            catch (UnauthorizedAccessException ua)
            {
                stream.Close();
                return false;
            }

        }

        public List<Video> obtenerTodosLosDatos()
        {

            try
            {
                List<Video> videos = new List<Video>();
                formatter = new BinaryFormatter();
                Video video;
                stream = new FileStream(nombre, FileMode.Open, FileAccess.Read, FileShare.Read);
                while (!(stream.Position == stream.Length))
                {

                    video = (Video)formatter.Deserialize(stream);
                    if (video != null)
                    {
                        videos.Add(video);
                    }
                }

                return videos;
            }
            catch (IOException e)
            {
                return new List<Video>();
            }
            catch (SecurityException x)
            {
                return new List<Video>();
            }
            catch (UnauthorizedAccessException a)
            {
                return new List<Video>();
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                    stream = null;
                }
            }

        }
    }
}
