using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class Persona
    {
        private String nombre;

        public Persona(String nombre)
        {
            this.nombre = nombre;
        }

        public Persona() {

        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
    }
}
