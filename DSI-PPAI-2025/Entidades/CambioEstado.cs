using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    public class CambioEstado
    {
        private DateTime fechasHoraInicio;
        private DateTime fechasHoraFin;
        private Estado estado;

        public CambioEstado(DateTime fechasHoraInicio, DateTime fechasHoraFin, Estado estado) 
        {
            this.fechasHoraFin = fechasHoraFin;
            this.estado = estado;   
            this.fechasHoraInicio = fechasHoraInicio;
        
        }

        public DateTime FechasHoraInicio { get => fechasHoraInicio; set => fechasHoraInicio = value; }
        public DateTime FechasHoraFin { get => fechasHoraFin; set => fechasHoraFin = value; }

        public Estado Estado { get => estado; set => estado = value; }


    }
}
