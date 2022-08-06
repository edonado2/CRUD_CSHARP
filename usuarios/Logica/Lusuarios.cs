using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace usuarios.Logica
{
    class Lusuarios
    {
        private int idUsuario;
        private string usuario;
        private string password;
        private byte[] icon;
        private string status;

        public int Idusuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public byte[] Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Lusuarios()
        {

        }
        public Lusuarios(int idUsuario, 
                         string usuario,
                         string password,
                         byte[] icon,
                         string status)
        {
            Idusuario = idUsuario;
            Usuario = usuario;
            Password = password;
            Icon = icon;
            Status = status;
        }

    }
}
