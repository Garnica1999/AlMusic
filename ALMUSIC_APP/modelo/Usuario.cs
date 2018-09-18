using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMUSIC_APP.modelo
{
    [Serializable]
    public class Usuario : Persona
    {
        private long idPersona;
        private String usuario;
        private String contrasenia;
        private int diaNacimiento;
        private int mesNacimiento;
        private int anioNacimiento;
        private String paisResidencia;
        private String claveLicencia;
        private String correo;
        private String idHDD;

        public Usuario(long idPersona, string usuario, string contrasenia, int diaNacimiento, int mesNacimiento, int anioNacimiento, string paisResidencia, string claveLicencia, string correo, string idHDD, string nombre) : base(nombre)
        {
            
            this.idPersona = idPersona;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.diaNacimiento = diaNacimiento;
            this.mesNacimiento = mesNacimiento;
            this.anioNacimiento = anioNacimiento;
            this.paisResidencia = paisResidencia;
            this.claveLicencia = claveLicencia;
            this.correo = correo;
            this.idHDD = idHDD;
        }

        public long getIdPersona()
        {
            return idPersona;
        }

        public void setIdPersona(long idPersona)
        {
            this.idPersona = idPersona;
        }

        public String getUsuario()
        {
            return usuario;
        }

        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        public String getContrasenia()
        {
            return contrasenia;
        }

        public void setContrasenia(String contrasenia)
        {
            this.contrasenia = contrasenia;
        }

        public int getDiaNacimiento()
        {
            return diaNacimiento;
        }

        public void setDiaNacimiento(int diaNacimiento)
        {
            this.diaNacimiento = diaNacimiento;
        }

        public int getMesNacimiento()
        {
            return mesNacimiento;
        }

        public void setMesNacimiento(int mesNacimiento)
        {
            this.mesNacimiento = mesNacimiento;
        }

        public int getAnioNacimiento()
        {
            return anioNacimiento;
        }

        public void setAnioNacimiento(int anioNacimiento)
        {
            this.anioNacimiento = anioNacimiento;
        }

        public String getPaisResidencia()
        {
            return paisResidencia;
        }

        public void setPaisResidencia(String paisResidencia)
        {
            this.paisResidencia = paisResidencia;
        }

        public String getClaveLicencia()
        {
            return claveLicencia;
        }

        public void setClaveLicencia(String claveLicencia)
        {
            this.claveLicencia = claveLicencia;
        }

        public String getCorreo()
        {
            return correo;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        public String getIdHDD()
        {
            return idHDD;
        }

        public void setIdHDD(String idHDD)
        {
            this.idHDD = idHDD;
        }
    }
}
