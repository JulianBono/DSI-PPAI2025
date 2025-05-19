using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    public class Usuario
    {
        private string contraseña;
        private string nombreUsuario;
        private Empleado empleado;




        public Usuario(string contraseña, string nombreUsuario, Empleado empleado)
        { 
            this.contraseña = contraseña ;
            this.nombreUsuario = nombreUsuario ;
            this.empleado = empleado ;
        
        }


        public string Contraseña { get => contraseña; set => contraseña = value; }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }




        public Empleado getEmpleado()
        {
            return this.empleado;
        }



    }


}
