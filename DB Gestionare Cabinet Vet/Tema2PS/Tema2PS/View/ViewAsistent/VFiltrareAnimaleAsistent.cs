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

namespace Tema2PS.View.ViewAsistent
{
    public partial class VFiltrareAnimaleAsistent : Form
    {
        public VFiltrareAnimaleAsistent()
        {
            InitializeComponent();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAsistent v = new VAsistent();
            v.Show();
        }

        private void btnCauta1_Click(object sender, EventArgs e)
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

        private void btn3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("FiseSearchBySpecie", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SpecieAnimal", txtSpecieAnimal.Text);
                DataTable dtbUtilizator = new DataTable();
                sqlDa.Fill(dtbUtilizator);
                dgv3.DataSource = dtbUtilizator;
            }
        }

        private void btnCauta2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("FiseSearchByMedic", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_MedicFisa", txtMedID.Text);
                DataTable dtbUtilizator = new DataTable();
                sqlDa.Fill(dtbUtilizator);
                dgv2.DataSource = dtbUtilizator;
            }
        }
    }
}
