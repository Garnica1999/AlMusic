using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class ListaReproduccion
    {
        private string nombre;
        private int cantidad;
        public ListaReproduccion(string nombre)
        {
            this.cantidad = 0;
            this.nombre = nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public int getCantidad() {
            return this.cantidad;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        
    }
}
