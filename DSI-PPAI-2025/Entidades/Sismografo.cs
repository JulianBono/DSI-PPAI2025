using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    public class Sismografo
    {
        private DateTime fechaAdquisicion;
        private int identificadorSismografo;
        private int nroSerie;
        private CambioEstado cambioEstado;
        private EstacionSismologica estacionSismologica;


        public Sismografo(DateTime fechaAdquisicion, int identificadorSismografo, int nroSerie, CambioEstado cambioEstado, EstacionSismologica estacionSismologica)
        {
            this.cambioEstado = cambioEstado;
            this.fechaAdquisicion = fechaAdquisicion;
            this.nroSerie = nroSerie;   
            this.identificadorSismografo = identificadorSismografo;

            this.estacionSismologica = estacionSismologica;


        }

        private DateTime FechaAdquisicion { get => fechaAdquisicion; set => fechaAdquisicion = value; }
        private int IdentificadorSismografo { get => identificadorSismografo; set => identificadorSismografo = value; }
        private int NroSerie { get => nroSerie; set => nroSerie = value; }
        private CambioEstado CambioEstado { get => cambioEstado; set => cambioEstado = value; }

        private EstacionSismologica EstacionSismologica { get => estacionSismologica; set => estacionSismologica = value; }


    
}
    }
}
