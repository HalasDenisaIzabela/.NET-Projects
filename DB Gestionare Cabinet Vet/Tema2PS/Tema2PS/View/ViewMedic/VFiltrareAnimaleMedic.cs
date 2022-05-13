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

namespace Tema2PS.View.ViewMedic
{
    public partial class VFiltrareAnimaleMedic : Form
    {
        public VFiltrareAnimaleMedic()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("FiseSearchByDiagnostic", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_Diagnostic", txtDiagnosticF.Text);
                DataTable dtbUtilizator = new DataTable();
                sqlDa.Fill(dtbUtilizator);
                dgv1.DataSource = dtbUtilizator;
            }
        }

        private void btnCauta2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("FiseSearchByTratament", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_Tratament", txtTratamentF.Text);
                DataTable dtbUtilizator = new DataTable();
                sqlDa.Fill(dtbUtilizator);
                dgv2.DataSource = dtbUtilizator;
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            VMedic v = new VMedic();
            v.Show();
        }
    }
}
