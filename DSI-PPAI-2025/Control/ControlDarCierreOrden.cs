using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI_2025.Boundary.Cerrar;
using DSI_PPAI_2025.Entidades;

namespace DSI_PPAI_2025.Control
{
    public class ControlDarCierreOrden
    {

        PantDarCierreOrden pantDarCierreOrden { get; set; }
        Session sesionActual { get; set; }





        public void iniciarCierreOrden(PantDarCierreOrden pantDarCierreOrden)
        {
            
            this.pantDarCierreOrden = pantDarCierreOrden;
            this.obtenerRILogueado(); 

            Usuario usuario = this.sesionActual.obtenerUsuario();
           
            Empleado empleado = usuario.getEmpleado();

          
            
            var ordenes = this.buscarOrdenesDeRIRealizadas();
            this.ordenarOrdenesPorFechaFinalizacion(ordenes);

        }
        public void obtenerRILogueado()
        {

            this.sesionActual = new Session(
                DateTime.Now,
                null,
                new Usuario(
                    "123456",
                    "Tomi",
                    new Empleado(
                        "Mendez",
                        "tomitomi4@gmail.com",
                        "Thomas",
                        35583721,
                        new Rol("Encargado de inspeccionar las estaciones", "Inspector")
                    )
                )


            );

 

        }

       
                public List<Dictionary<string, object>> buscarOrdenesDeRIRealizadas()
                 {
                    List<Dictionary<string, object>> ordenesValidas = new List<Dictionary<string, object>>();

                    // Obtener el empleado logueado
                    Empleado empleadoLogueado = this.sesionActual.obtenerUsuario().getEmpleado();

                    // obtener todas las órdenes de inspección
                    List<OrdenDeInspeccion> todasLasOrdenes = ObtenerTodasLasOrdenesDeInspeccion();
                    int i = 0;
                    // Loop mientras haya órdenes por buscar
                    foreach (OrdenDeInspeccion orden in todasLasOrdenes)
                    {
                        // Verificar si la orden es del empleado y está realizada
                        if (orden.esDeEmpleado(empleadoLogueado) && orden.esRealizada())
                        {
                            // Verificar el estado
                            if (orden.Estado.esAmbito("Inspección") && orden.Estado.esRealizada())
                            {
                                
                                // Buscar datos de la orden
                                Dictionary<string, object> datosOrden = orden.buscarDatos(i);
                                ordenesValidas.Add(datosOrden);
                                i =i+ 1;
                            }
                        }
                    }

                    return ordenesValidas;
        }

       
        private List<OrdenDeInspeccion> ObtenerTodasLasOrdenesDeInspeccion()
        {
            
            return new List<OrdenDeInspeccion>
        {
            new OrdenDeInspeccion(
                DateTime.Now.AddDays(-5),
                DateTime.Now.AddDays(-3),
                DateTime.MinValue,
                "",
                new Estado("Inspección", "Realizada"),
                new EstacionSismologica(1, "DOC123", DateTime.Now.AddDays(-10), 123, 456, "Estación Central", 789),
                this.sesionActual.obtenerUsuario().getEmpleado()


            ),
             new OrdenDeInspeccion(
                DateTime.Now.AddDays(-7),
                DateTime.Now.AddDays(-4),
                DateTime.MinValue,
                "",
                new Estado("Inspección", "Realizada"),
                new EstacionSismologica(1, "AOC423", DateTime.Now.AddDays(-12), 143, 766, "Estación Central Sur", 79),
                this.sesionActual.obtenerUsuario().getEmpleado()),

              new OrdenDeInspeccion(
                DateTime.Now.AddDays(-7),
                DateTime.Now.AddDays(-4),
                DateTime.MinValue,
                "",
                new Estado("Inspección", "Realizada"),
                new EstacionSismologica(1, "VHC573", DateTime.Now.AddDays(-32), 63, 46, "Estación Central Norte", 19),
                this.sesionActual.obtenerUsuario().getEmpleado()),
            
        };

        }

        public void ordenarOrdenesPorFechaFinalizacion(List<Dictionary<string, object>> ordenes)
        {
            try
            {
         // Buscar y ordenar las órdenes
                var ordenesValidas = ordenes
                    .OrderByDescending(orden => (DateTime)orden["fechaFinalizacion"])
                    .ToList();

            // Preparar datos para la grilla
                var datosParaGrilla = ordenesValidas.Select(orden => new
                {
                    NumeroOrden = orden["numeroOrden"].ToString(),
                    FechaFinalizacion = ((DateTime)orden["fechaFinalizacion"]).ToString("dd/MM/yyyy HH:mm"),
                    NombreEstacion = orden["nombreEstacion"].ToString(),
                    IdSismografo = orden["idSismografo"].ToString()
                }).ToList();

                //Mostrar en grilla
                pantDarCierreOrden.pedirSeleccionOrdenInspeccion(datosParaGrilla.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar órdenes: {ex.Message}");
            }
        }

       
    }
}


       