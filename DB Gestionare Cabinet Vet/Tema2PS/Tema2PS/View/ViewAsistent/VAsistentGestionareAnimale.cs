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

namespace Tema2PS.View.ViewAsistent
{
    public partial class VAsistentGestionareAnimale : Form
    {
        private VMAnimal vm;
        public VAsistentGestionareAnimale()
        {
            InitializeComponent();
            this.dgvAnimale.AllowUserToAddRows = false;
            for (int i = 0; i < dgvAnimale.ColumnCount; i++)
                this.dgvAnimale.Columns[i].ReadOnly = true;

            this.vm = new VMAnimal();
            this.txtCIPAnimal.DataBindings.Add("Text", this.vm, "cipAnim", false, DataSourceUpdateMode.OnValidation);
            this.txtSpecieAnimal.DataBindings.Add("Text", this.vm, "specieAnim", false, DataSourceUpdateMode.OnValidation);
            this.dgvAnimale.DataSource = this.vm.Animalele;

            this.btnVizualizare.Click += delegate { vm.VizualizareC.Executa(); Clear(); };
            this.btnCreare.Click += delegate
            {
                vm.CipAnim = 0;
                vm.CreareC.Executa();
                vm.VizualizareC.Executa();
                Clear();
            };
            this.btnActualizare.Click += delegate { vm.CreareC.Executa(); vm.VizualizareC.Executa(); Clear(); };
            this.btnStergere.Click += delegate { vm.StergereC.Executa(); vm.VizualizareC.Executa(); Clear(); };
        }
        void Clear()
        {
            txtCIPAnimal.Text = txtSpecieAnimal.Text = txtCautareAnimal.Text  = "";
            btnActualizare.Enabled = false;
            btnCreare.Enabled = Enabled;
            btnStergere.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAsistent v = new VAsistent();
            v.Show();
        }

        private void btnCitire_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("AnimaleSearchBySpecie", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_Specie", txtCautareAnimal.Text);
                DataTable dtbAnimal = new DataTable();
                sqlDa.Fill(dtbAnimal);
                dgvAnimale2.DataSource = dtbAnimal;

            }
        }

        private void VAsistentGestionareAnimale_Load(object sender, EventArgs e)
        {
            btnStergere.Enabled = false;
            btnActualizare.Enabled = false;
            vm.VizualizareC.Executa();
        }

        private void dgvAnimale_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAnimale.CurrentRow.Index != -1)
            {
                txtCIPAnimal.Text = dgvAnimale.CurrentRow.Cells[0].Value.ToString();
                vm.CipAnim = Convert.ToInt32(txtCIPAnimal.Text);
                txtSpecieAnimal.Text = dgvAnimale.CurrentRow.Cells[1].Value.ToString();
                vm.SpecieAnim = txtSpecieAnimal.Text;
                btnActualizare.Enabled = Enabled;
                btnStergere.Enabled = Enabled;
                btnCreare.Enabled = false;
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {

        }
    }
}
