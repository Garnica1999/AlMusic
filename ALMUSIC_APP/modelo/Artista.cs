using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class Artista : Persona
    {
        private ArrayList albumes;

        public Artista(string nombre) : base(nombre)
        {
            
        }

        public Artista() : base()
        {

        }

        public ArrayList getAlbumes()
        {
            return albumes;
        }

        public void setAlbumes(ArrayList albumes)
        {
            this.albumes = albumes;
        }
    }
}
