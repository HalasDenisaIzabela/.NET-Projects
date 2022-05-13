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
    public partial class VGestionareFiseMedicaleMedic : Form
    {
        private VMFisaMedicala vm3;
        public VGestionareFiseMedicaleMedic()
        {
            InitializeComponent();
            this.dgvFiseF.AllowUserToAddRows = false;
            for (int i = 0; i < dgvFiseF.ColumnCount; i++)
                this.dgvFiseF.Columns[i].ReadOnly = true;

            this.vm3 = new VMFisaMedicala();
            this.txtNrCrtF.DataBindings.Add("Text", this.vm3, "nrCrtF", false, DataSourceUpdateMode.OnValidation);
            this.txtCipA.DataBindings.Add("Text", this.vm3, "cipAnimF", false, DataSourceUpdateMode.OnValidation);
            this.txtSpecieA.DataBindings.Add("Text", this.vm3, "specieAnimF", false, DataSourceUpdateMode.OnValidation);
            this.txtIdM.DataBindings.Add("Text", this.vm3, "idUtilF", false, DataSourceUpdateMode.OnValidation);
            this.txtZiuaF.DataBindings.Add("Text", this.vm3, "ziuaF", false, DataSourceUpdateMode.OnValidation);
            this.txtOraF.DataBindings.Add("Text", this.vm3, "oraF", false, DataSourceUpdateMode.OnValidation);
            this.txtSimptomF.DataBindings.Add("Text", this.vm3, "simptomF", false, DataSourceUpdateMode.OnValidation);
            this.txtDiagnosticF.DataBindings.Add("Text", this.vm3, "diagnosticF", false, DataSourceUpdateMode.OnValidation);
            this.txtTratamentF.DataBindings.Add("Text", this.vm3, "tratamentF", false, DataSourceUpdateMode.OnValidation);
            this.dgvFiseF.DataSource = this.vm3.FiseF;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            VMedic v = new VMedic();
            v.Show();
        }

        private void VGestionareFiseMedicaleMedic_Load(object sender, EventArgs e)
        {
            vm3.VizualizareFisaC.Executa();
        }

        private void dgvFiseF_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFiseF.CurrentRow.Index != -1)
            {
                txtNrCrtF.Text = dgvFiseF.CurrentRow.Cells[0].Value.ToString();
                vm3.NrCrtF = Convert.ToInt32(txtNrCrtF.Text);

                txtCipA.Text = dgvFiseF.CurrentRow.Cells[1].Value.ToString();
                vm3.CipAnimF = Convert.ToInt32(txtCipA.Text);

                txtSpecieA.Text = dgvFiseF.CurrentRow.Cells[2].Value.ToString();
                vm3.SpecieAnimF = txtSpecieA.Text;

                txtIdM.Text = dgvFiseF.CurrentRow.Cells[3].Value.ToString();
                vm3.IdUtilF = Convert.ToInt32(txtIdM.Text);

                txtZiuaF.Text = dgvFiseF.CurrentRow.Cells[4].Value.ToString();
                vm3.ZiuaF = txtZiuaF.Text;

                txtOraF.Text = dgvFiseF.CurrentRow.Cells[5].Value.ToString();
                vm3.OraF = Convert.ToInt32(txtOraF.Text);

                txtSimptomF.Text = dgvFiseF.CurrentRow.Cells[6].Value.ToString();
                vm3.SimptomF = txtSimptomF.Text;

                txtDiagnosticF.Text = dgvFiseF.CurrentRow.Cells[7].Value.ToString();
                vm3.DiagnosticF = txtDiagnosticF.Text;

                txtTratamentF.Text = dgvFiseF.CurrentRow.Cells[8].Value.ToString();
                vm3.TratamentF = txtTratamentF.Text;
            }
        }

        private void btnSDT_Click(object sender, EventArgs e)
        {
            vm3.CreareFisaC.Executa();
            vm3.VizualizareFisaC.Executa();
        }
    }
}
