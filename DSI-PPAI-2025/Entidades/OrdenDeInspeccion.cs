using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI_2025.Entidades
{
    internal class OrdenDeInspeccion
    {

        public DateTime fechaHoraInicio;
        public DateTime fechaHoraFinalizacion;
        public DateTime fechaHoraCierre;
        public string observacionCierre;
        public Estado estado;
        public EstacionSismologica estacionSismologica;
        public Empleado empleado;
        


        public OrdenDeInspeccion(DateTime fechaHoraInicio, DateTime fechaHoraFinalizacion, DateTime fechaHoraCierre, string observacionCierre, Estado estado, EstacionSismologica estacionSismologica, Empleado empleado) { 
        
            this.fechaHoraInicio = fechaHoraInicio; 
            this.fechaHoraFinalizacion = fechaHoraFinalizacion;
            this.fechaHoraCierre = fechaHoraCierre;
            this.observacionCierre = observacionCierre;
            this.estado = estado;
            this.empleado = empleado;
            this.estacionSismologica = estacionSismologica;
          

        
        }

        public DateTime FechaHoraInicio { get => fechaHoraInicio; private set => fechaHoraInicio = value; }
        public DateTime FechaHoraFinalizacion { get => fechaHoraFinalizacion; private set => fechaHoraFinalizacion = value; }
        public DateTime FechaHoraCierre { get => fechaHoraCierre; private set => fechaHoraCierre = value; }
        public string ObservacionCierre { get => observacionCierre; private set => observacionCierre = value; }
        public Estado Estado { get => estado; private set => estado = value; }
        public Empleado Empleado { get => empleado; private set => empleado = value; }
        public EstacionSismologica EstacionSismologica { get => estacionSismologica;private set => estacionSismologica = value; }


        public bool esDeEmpleado(Empleado empleado)
        {
            return this.empleado.Equals(empleado);
        }

        public bool esRealizada()
        {
            return this.estado.NombreEstado == "Realizada";
        }

        public Dictionary<string, object> buscarDatos(int i)
        {
            Dictionary<string, object> datos = new Dictionary<string, object>();

            datos.Add("numeroOrden", this.getNumeroDeOrden());
            datos.Add("fechaFinalizacion", this.getFechaHoraFinalizacion(i));
            datos.Add("nombreEstacion", this.estacionSismologica.getNombre());
            datos.Add("idSismografo", this.estacionSismologica.obtenerIdSismografo(i));

            return datos;
        }

        public string getNumeroDeOrden()
        {
            
            return "ORD-" + this.fechaHoraInicio.ToString("yyyyMMddHHmm");
        }

        public DateTime getFechaHoraFinalizacion(int i)
        {
            return this.fechaHoraFinalizacion.AddDays(-i);
        }


         



    }
}
