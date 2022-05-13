using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2PS.View.ViewAsistent
{
    public partial class VAsistent : Form
    {
        public VAsistent()
        {
            InitializeComponent();
        }
        /*
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
        }*/
        private void btnGestAnimale_Click(object sender, EventArgs e)
         {
            this.Hide();
            VAsistentGestionareAnimale v = new VAsistentGestionareAnimale();
            v.Show();
         }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Logare v = new Logare();
            v.Show();
        }

        private void btnSalvareAnimale_Click(object sender, EventArgs e)
        {
            this.Hide();
            VSalvareListeAnimale v = new VSalvareListeAnimale();
            v.Show();
        }

        private void btnPlanifConsult_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAsistentPlanificareConsultatii v = new VAsistentPlanificareConsultatii();
            v.Show();
        }

        private void btnFiltAnimale_Click(object sender, EventArgs e)
        {
            this.Hide();
            VFiltrareAnimaleAsistent v = new VFiltrareAnimaleAsistent();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VVizualizareStatistici v = new VVizualizareStatistici();
            v.Show();
        }
    }
}
