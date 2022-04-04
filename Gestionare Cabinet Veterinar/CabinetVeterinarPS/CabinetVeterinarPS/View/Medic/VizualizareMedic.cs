using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetVeterinarPS.View.Medic;

namespace CabinetVeterinarPS.View
{
    public partial class VizualizareMedic : Form
    {
        public VizualizareMedic()
        {
            InitializeComponent();
        }

        private void btnGestProgram_Click(object sender, EventArgs e)
        {
            VizualizareGestionareProgram v = new VizualizareGestionareProgram();
            this.Hide();
            v.Show();

        }

        private void btnFiltrareAnimale_Click(object sender, EventArgs e)
        {
            VizualizareFiltrareAnimale v = new VizualizareFiltrareAnimale();
            this.Hide();
            v.Show();
        }

        private void btnGestFise_Click(object sender, EventArgs e)
        {
            VizualizareGestionareFiseMedicale v = new VizualizareGestionareFiseMedicale();
            this.Hide();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareAutentificare v = new VizualizareAutentificare();
            v.Show();
        }
    }
}
