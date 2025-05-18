using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    public class Session
    {
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private Usuario usuario;

    
        public Session(DateTime fecha_inicio, DateTime fecha_fin, Usuario usuario) 
        { 
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.usuario = usuario;

        }

        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }

        public DateTime? Fecha_fin { get => fecha_fin; set => fecha_fin = value; }

        public Usuario Usuario { get => usuario; set => usuario = value; }


    }
}
