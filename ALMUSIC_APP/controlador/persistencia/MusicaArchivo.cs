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
    public class MusicaArchivo
    {
        private IFormatter formatter;
        private Stream stream;
        private string nombre;
        public MusicaArchivo(string nombre) {
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

        private void eliminarArchivo() {
            if (File.Exists(nombre)) {
                File.Delete(nombre);
            }
        }

        public bool ingresarDato(Musica musica) {
            try
            {
                formatter = new BinaryFormatter();
                stream = new FileStream(nombre, FileMode.Append, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, musica);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                return false;
            }
            catch (SecurityException s)
            {
                return false;
            }catch(UnauthorizedAccessException ua)
            {
                return false;
            }
            
        }

        public List<Musica> obtenerTodosLosDatos()
        {

            try
            {
                List<Musica> canciones = new List<Musica>();
                formatter = new BinaryFormatter();
                Musica musica;
                stream = new FileStream(nombre, FileMode.Open, FileAccess.Read, FileShare.Read);
                while (!(stream.Position == stream.Length))
                {

                    musica = (Musica)formatter.Deserialize(stream);
                    if (musica != null)
                    {
                        canciones.Add(musica);
                    }
                }
                
                return canciones;
            }
            catch (IOException e)
            {
                return new List<Musica>();
            }
            catch (SecurityException x) {
                return new List<Musica>();
            }
            catch(UnauthorizedAccessException a)
            {
                return new List<Musica>();
            }
            finally
            {
                if(stream != null)
                {
                    stream.Close();
                    stream = null;
                }
            }
            
        }
    }
}
