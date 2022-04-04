using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetVeterinarPS.View.Asistent;

namespace CabinetVeterinarPS.View
{
    public partial class VizualizareAsistent : Form
    {
        public VizualizareAsistent()
        {
            InitializeComponent();
        }

        private void btnGestAnimale_Click(object sender, EventArgs e)
        {
            VizualizareGestionareAnimale v = new VizualizareGestionareAnimale();
            this.Hide();
            v.Show();
        }

        private void btnFiltAnimale_Click(object sender, EventArgs e)
        {
            VizualizareFiltrareAnimale v = new VizualizareFiltrareAnimale();
            this.Hide();
            v.Show();
        }

        private void btnPlanifConsult_Click(object sender, EventArgs e)
        {
            VizualizarePlanificareCnsultatii v = new VizualizarePlanificareCnsultatii();
            this.Hide();
            v.Show();
        }

        private void btnSalvareAnimale_Click(object sender, EventArgs e)
        {
            VizualizareSalvareListeAnimale v = new VizualizareSalvareListeAnimale();
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
