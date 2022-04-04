using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetVeterinarPS.Presenter;

namespace CabinetVeterinarPS.View.Asistent
{
    public partial class VizualizareSalvareListeAnimale : Form, IVizualizareSalvareListeAnimale
    {
        public VizualizareSalvareListeAnimale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareAsistent v = new VizualizareAsistent();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrezenareSalvareListeAnimale pp = new PrezenareSalvareListeAnimale(this);
            pp.CSV();
        }

        private void VizualizareSalvareListeAnimale_Load(object sender, EventArgs e)
        {

        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            PrezenareSalvareListeAnimale pp = new PrezenareSalvareListeAnimale(this);
            pp.JSON();
        }
    }
}
