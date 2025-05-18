using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    public class Rol
    {
        private string descripcionRol;
        private string nombre;



        public Rol(string descripcionRol, string nombre )
        {
            this.descripcionRol = descripcionRol;
            this.nombre = nombre;


        }


        public string DescripcionRol { get => descripcionRol; set => descripcionRol = value; }

        public string Nombre { get => nombre; set => nombre = value; }



    }
}
