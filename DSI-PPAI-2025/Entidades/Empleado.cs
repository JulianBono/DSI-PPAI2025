using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    public class Empleado
    {
        private string apellido;
        private string mail;
        private string nombre;
        private int telefono;
        private Rol rol;
        



        public Empleado(string apellido, string mail, string nombre, int telefono, Rol rol) 
        {
            this.apellido = apellido;
            this.mail = mail;
            this.nombre = nombre;
            this.rol = rol;

        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public Rol Rol { get => rol; set => rol = value; }



       
    }


}
