using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class Caratula : Directorio
    {
        private String mimeData;
        private byte[] datosBinarios;

        public Caratula(String rutaDeCarpeta) : base(rutaDeCarpeta)
        {
            
        }

        public String getMimeData()
        {
            return mimeData;
        }

        public void setMimeData(String mimeData)
        {
            this.mimeData = mimeData;
        }

        public byte[] getDatosBinarios()
        {
            return datosBinarios;
        }

        public void setDatosBinarios(byte[] datosBinarios)
        {
            this.datosBinarios = datosBinarios;
        }
    }
}
