using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    public class EstacionSismologica
    {
        private int codigoEstacion;
        private string documentoCertificadoAdq;
        private DateTime fechaSolicitudCertificado;
        private int latitud;
        private int longitud;
        private string nombre;
        private int nroCertificadoAdquisicion;
        //private List<Sismografo> sismografos;


        public EstacionSismologica(int codigoEstacion, string documentoCertificadoAdq, DateTime fechaSolicitudCertificado, int latitud, int longitud, string nombre, int nroCertificadoAdquisicion) 
        { 
            this.latitud = latitud; 
            this.nombre = nombre;
            this.fechaSolicitudCertificado = fechaSolicitudCertificado;
            this.codigoEstacion = codigoEstacion;
            this.documentoCertificadoAdq = documentoCertificadoAdq;
            this.nroCertificadoAdquisicion = nroCertificadoAdquisicion;
            this.longitud = longitud;
            //this.sismografos = new List<Sismografo>();  


        }

        private DateTime FechaSolicitudCertificado { get => fechaSolicitudCertificado; set => fechaSolicitudCertificado = value; }
        private int Latitud { get => latitud; set => latitud = value; } 
        private string DocumentoCertificadoAdq { get => documentoCertificadoAdq; set => documentoCertificadoAdq = value; }
        private int CodigoEstacion { get => codigoEstacion; set => codigoEstacion = value; }
        private int Longitud { get => longitud; set => longitud = value; }
        private string Nombre { get => nombre; set => nombre = value; }
        private int NroCertificadoAdquisicion { get => nroCertificadoAdquisicion; set => nroCertificadoAdquisicion = value; }

        //private List<Sismografo> Sismografos { get => sismografos; set => sismografos = value; }  
        

    }
}
