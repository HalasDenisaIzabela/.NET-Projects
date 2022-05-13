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

namespace Tema2PS.View.ViewMedic
{
    public partial class VGestionareProgramMedic : Form
    {
        private VMMedic vm;
        public VGestionareProgramMedic()
        {
            InitializeComponent();
            this.dgvMedici.AllowUserToAddRows = false;
            for (int i = 0; i < dgvMedici.ColumnCount; i++)
                this.dgvMedici.Columns[i].ReadOnly = true;

            this.vm = new VMMedic();
            this.txtIdMed.DataBindings.Add("Text", this.vm, "idUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtRolMed.DataBindings.Add("Text", this.vm, "rolUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtEmailMed.DataBindings.Add("Text", this.vm, "emailUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtParolaMed.DataBindings.Add("Text", this.vm, "parolaUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtOraStart.DataBindings.Add("Text", this.vm, "oraStartMed", false, DataSourceUpdateMode.OnValidation);
            this.txtOraStop.DataBindings.Add("Text", this.vm, "oraStopMed", false, DataSourceUpdateMode.OnValidation);
            this.dgvMedici.DataSource = this.vm.Medici;
            this.btnAdaugareProgram.Click += delegate { vm.CreareProgramC.Executa(); vm.VizualizareProgramC.Executa(); };

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            VMedic v = new VMedic();
            v.Show();
        }

        private void VGestionareProgramMedic_Load(object sender, EventArgs e)
        {
            vm.VizualizareProgramC.Executa();
        }

        private void dgvMedici_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMedici.CurrentRow.Index != -1)
            {
                txtIdMed.Text = dgvMedici.CurrentRow.Cells[0].Value.ToString();
                vm.IdUtil = Convert.ToInt32(txtIdMed.Text);
                txtRolMed.Text = dgvMedici.CurrentRow.Cells[1].Value.ToString();
                vm.RolUtil = txtRolMed.Text;
                txtEmailMed.Text = dgvMedici.CurrentRow.Cells[2].Value.ToString();
                vm.EmailUtil = txtEmailMed.Text;
                txtParolaMed.Text = dgvMedici.CurrentRow.Cells[3].Value.ToString();
                vm.ParolaUtil = txtParolaMed.Text;
                txtOraStart.Text = dgvMedici.CurrentRow.Cells[4].Value.ToString();
                vm.OraStartMed = Convert.ToInt32(txtOraStart.Text);
                txtOraStop.Text = dgvMedici.CurrentRow.Cells[5].Value.ToString();
                vm.OraStopMed = Convert.ToInt32(txtOraStop.Text);
                //btnAdaugareProgram.Enabled = Enabled;
            }
        }

        private void txtOraStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnAdaugareProgram.Enabled = false;
        }
    }
}
