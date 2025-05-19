using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI_2025.Control;

namespace DSI_PPAI_2025.Boundary.Cerrar
{
    public partial class PantDarCierreOrden : Form
    {
        ControlDarCierreOrden controlDarCierreOrden {  get; set; }

        public PantDarCierreOrden()
        {
            InitializeComponent();
        }
        public void tomarOpNuevoCierreOrden(ControlDarCierreOrden controlDarCierreOrden)
        {
            this.habilitarVentana();

            this.controlDarCierreOrden = controlDarCierreOrden;
            controlDarCierreOrden.iniciarCierreOrden(this);

        }


        public void habilitarVentana()
        {
            this.Show();
        }

        public void pedirSeleccionOrdenInspeccion(List<object> ordenes)
        {


            grillaDatosOrden.Rows.Clear();
            grillaDatosOrden.Columns.Clear();
            grillaDatosOrden.Columns.Add("NumeroOrden", "Número de Orden");
            grillaDatosOrden.Columns.Add("FechaFinalizacion", "Fecha Finalización");
            grillaDatosOrden.Columns.Add("NombreEstacion", "Nombre Estación");
            grillaDatosOrden.Columns.Add("IdSismografo", "ID Sismógrafo");

           
            foreach (dynamic orden in ordenes)
            {
                grillaDatosOrden.Rows.Add(
                    orden.NumeroOrden,
                    orden.FechaFinalizacion,
                    orden.NombreEstacion,
                    orden.IdSismografo
                );
            }

        }
        private void SelectOrden_Click(object sender, EventArgs e)
        {

        }
    }
}
