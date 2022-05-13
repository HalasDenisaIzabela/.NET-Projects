using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tema2PS.ViewModel;

namespace Tema2PS.View
{
    public partial class Logare : Form
    {
        private VMUtilizator vm;
        public Logare()
        {
            InitializeComponent();
            this.vm = new VMUtilizator();
            this.txtEmailLog.DataBindings.Add("Text", this.vm, "emlLog", false, DataSourceUpdateMode.OnValidation);
            this.txtParolaLog.DataBindings.Add("Text", this.vm, "parLog", false, DataSourceUpdateMode.OnValidation);
            this.btnAutentificare.Click += delegate 
            { 
                if(vm.LogareC.Executa2() == true)
                    this.Hide();
                txtEmailLog.Clear();
                txtParolaLog.Clear();
            };

        }

        private void Logare_Load(object sender, EventArgs e)
        {

        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            
        }
    }
}
