using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2PS.ViewModel;

namespace Tema2PS.View.ViewAsistent
{
    public partial class VSalvareListeAnimale : Form
    {
        private VMAnimal vm;

        public VSalvareListeAnimale()
        {
            InitializeComponent();
            this.vm = new VMAnimal();
            this.btnCSV.Click += delegate { vm.SalvareCSVC.Executa(); };
            this.btnJSON.Click += delegate { vm.SalvareJSONC.Executa(); };
            this.btnXML.Click += delegate { vm.SalvareXMLC.Executa(); };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAsistent v = new VAsistent();
            v.Show();
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {

        }
    }
}
