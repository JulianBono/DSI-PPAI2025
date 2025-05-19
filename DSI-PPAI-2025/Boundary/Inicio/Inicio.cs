using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI_2025.Boundary.Cerrar;
using DSI_PPAI_2025.Control;

namespace DSI_PPAI_2025.Boundary
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ordenCierreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantDarCierreOrden pantalla = new PantDarCierreOrden();
            ControlDarCierreOrden controlDarCierreOrden = new ControlDarCierreOrden();
            pantalla.tomarOpNuevoCierreOrden(controlDarCierreOrden);

        }
    }



}
