using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    public class Estado
    {
        private string ambito;
        private string nombreEstado;


        public Estado(string ambito, string nombreEstado) 
        { 
            this.ambito = ambito;
            this.nombreEstado = nombreEstado;

        }


        public string Ambito { get => ambito; set => ambito = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }





    }
}
