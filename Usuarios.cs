using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoU1P2
{
    internal class Usuarios
    {
        private String Nombre;
        private String Apellido;
        private String Contra;

        public Usuarios(String n, String ap, String contra) 
        { 
            this.Nombre = n;
            this.Apellido = ap;
            this.Contra = contra;
        }

        public String nombre
        {
            get { return this.Nombre; }
            set { this.Nombre = value; }
        }

        public String apellido
        {
            get { return this.Apellido; }
            set { this.Apellido = value; }
        }

        public String contra
        {
            get { return this.Contra; }
            set { this.Contra = value; }
        }
    }
}
