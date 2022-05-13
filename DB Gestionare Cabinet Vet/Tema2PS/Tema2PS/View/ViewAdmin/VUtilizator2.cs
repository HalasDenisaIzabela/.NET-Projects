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
    public partial class VUtilizator2 : Form
    {
        private VMUtilizator vm;

        public VUtilizator2()
        {
            InitializeComponent();
            this.dgvUtilizatori.AllowUserToAddRows = false;
            for (int i = 0; i < dgvUtilizatori.ColumnCount; i++)
                this.dgvUtilizatori.Columns[i].ReadOnly = true;

            this.vm = new VMUtilizator();
            this.txtId.DataBindings.Add("Text", this.vm, "idUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtRol.DataBindings.Add("Text", this.vm, "rolUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtEmail.DataBindings.Add("Text", this.vm, "emailUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtParola.DataBindings.Add("Text", this.vm, "parolaUtil", false, DataSourceUpdateMode.OnValidation);
            this.dgvUtilizatori.DataSource = this.vm.Utilizatori;

            this.btnVizualizare.Click += delegate { vm.VizualizareC.Executa(); Clear(); };
            this.btnCreare.Click += delegate 
            { 
                vm.IdUtil = 0;
                vm.CreareC.Executa(); 
                vm.VizualizareC.Executa(); 
                Clear(); };
            this.btnActualizare.Click += delegate { vm.CreareC.Executa(); vm.VizualizareC.Executa(); Clear(); };
            this.btnStergere.Click += delegate { vm.StergereC.Executa(); vm.VizualizareC.Executa(); Clear(); };
        }

        private void VUtilizator2_Load(object sender, EventArgs e)
        {
            btnStergere.Enabled = false;
            btnActualizare.Enabled = false;
            vm.VizualizareC.Executa();
        }

        void Clear()
        {
            txtRol.Text = txtEmail.Text = txtParola.Text = txtId.Text = "";
            btnActualizare.Enabled = false;
            btnCreare.Enabled = Enabled;
            btnStergere.Enabled = false;
        }

        private void dgvUtilizatori_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUtilizatori.CurrentRow.Index != -1)
            {
                txtRol.Text = dgvUtilizatori.CurrentRow.Cells[1].Value.ToString();
                vm.RolUtil = txtRol.Text;
                txtEmail.Text = dgvUtilizatori.CurrentRow.Cells[2].Value.ToString();
                vm.EmailUtil = txtEmail.Text;
                txtParola.Text = dgvUtilizatori.CurrentRow.Cells[3].Value.ToString();
                vm.ParolaUtil = txtParola.Text;
                txtId.Text = dgvUtilizatori.CurrentRow.Cells[0].Value.ToString();
                vm.IdUtil = Convert.ToInt32(txtId.Text);
                btnActualizare.Enabled = Enabled;
                btnStergere.Enabled = Enabled;
                btnCreare.Enabled = false;
            }
        }
        private void btnActualizare_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            vm.VizualizareC.Executa();
            Clear();
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("UtilizatorSearchByRol", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_RolUtilizator", txtCautare.Text);
                DataTable dtbUtilizator = new DataTable();
                sqlDa.Fill(dtbUtilizator);
                dgvUtilizatori2.DataSource = dtbUtilizator;
                dgvUtilizatori2.Columns[4].Visible = false;
                dgvUtilizatori2.Columns[5].Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logare v = new Logare();
            v.Show();
        }

        private void btnCreare_Click(object sender, EventArgs e)
        {

        }
    }
}
