using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class Directorio
    {
        private String rutaDeCarpeta;

        public Directorio(String rutaDeCarpeta)
        {
            this.rutaDeCarpeta = rutaDeCarpeta;
        }

        public String getRutaDeCarpeta()
        {
            return rutaDeCarpeta;
        }

        public void setRutaDeCarpeta(String rutaDeCarpeta)
        {
            this.rutaDeCarpeta = rutaDeCarpeta;
        }
    }
}
