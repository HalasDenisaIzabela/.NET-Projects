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
    public partial class VAsistentPlanificareConsultatii : Form
    {
        private VMMedic vm;
        private VMAnimal vm2;
        private VMFisaMedicala vm3;
        public VAsistentPlanificareConsultatii()
        {
            InitializeComponent();
            ////// Medic
            this.dgvMediciF.AllowUserToAddRows = false;
            for (int i = 0; i < dgvMediciF.ColumnCount; i++)
                this.dgvMediciF.Columns[i].ReadOnly = true;

            this.vm = new VMMedic();
            this.txtIdM.DataBindings.Add("Text", this.vm, "idUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtRolM.DataBindings.Add("Text", this.vm, "rolUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtEmailM.DataBindings.Add("Text", this.vm, "emailUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtParolaM.DataBindings.Add("Text", this.vm, "parolaUtil", false, DataSourceUpdateMode.OnValidation);
            this.txtOraStartM.DataBindings.Add("Text", this.vm, "oraStartMed", false, DataSourceUpdateMode.OnValidation);
            this.txtOraStopM.DataBindings.Add("Text", this.vm, "oraStopMed", false, DataSourceUpdateMode.OnValidation);
            this.dgvMediciF.DataSource = this.vm.Medici;

            /////// Animal
            this.dgvAnimaleF.AllowUserToAddRows = false;
            for (int i = 0; i < dgvAnimaleF.ColumnCount; i++)
                this.dgvAnimaleF.Columns[i].ReadOnly = true;

            this.vm2 = new VMAnimal();
            this.txtCipA.DataBindings.Add("Text", this.vm2, "cipAnim", false, DataSourceUpdateMode.OnValidation);
            this.txtSpecieA.DataBindings.Add("Text", this.vm2, "specieAnim", false, DataSourceUpdateMode.OnValidation);
            this.dgvAnimaleF.DataSource = this.vm2.Animalele;

            ////// Fise
            this.dgvFiseF.AllowUserToAddRows = false;
            for (int i = 0; i < dgvFiseF.ColumnCount; i++)
                this.dgvFiseF.Columns[i].ReadOnly = true;

            this.vm3 = new VMFisaMedicala();
            this.txtNrCrtF.DataBindings.Add("Text", this.vm3, "nrCrtF", false, DataSourceUpdateMode.OnValidation);
            //this.txtCipA.DataBindings.Add("Text", this.vm2, "cipAnim", false, DataSourceUpdateMode.OnValidation);
            //this.txtSpecieA.DataBindings.Add("Text", this.vm2, "specieAnim", false, DataSourceUpdateMode.OnValidation);
            //this.txtIdM.DataBindings.Add("Text", this.vm, "idUtil", false, DataSourceUpdateMode.OnValidation);
            //this.txtRolM.DataBindings.Add("Text", this.vm, "rolUtil", false, DataSourceUpdateMode.OnValidation);
            //this.txtEmailM.DataBindings.Add("Text", this.vm, "emailUtil", false, DataSourceUpdateMode.OnValidation);
            //this.txtParolaM.DataBindings.Add("Text", this.vm, "parolaUtil", false, DataSourceUpdateMode.OnValidation);
            //this.txtOraStartM.DataBindings.Add("Text", this.vm, "oraStartMed", false, DataSourceUpdateMode.OnValidation);
            //this.txtOraStopM.DataBindings.Add("Text", this.vm, "oraStopMed", false, DataSourceUpdateMode.OnValidation);

            this.txtCipAF.DataBindings.Add("Text", this.vm3, "cipAnimF", false, DataSourceUpdateMode.OnValidation);
            this.txtSpecieAF.DataBindings.Add("Text", this.vm3, "specieAnimF", false, DataSourceUpdateMode.OnValidation);
            this.txtIdMF.DataBindings.Add("Text", this.vm3, "idUtilF", false, DataSourceUpdateMode.OnValidation);


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
            VAsistent v = new VAsistent();
            v.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void VAsistentPlanificareConsultatii_Load(object sender, EventArgs e)
        {
            vm.VizualizareProgramC.Executa();
            vm2.VizualizareC.Executa();
            vm3.VizualizareFisaC.Executa();

        }

        private void dgvMediciF_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMediciF.CurrentRow.Index != -1)
            {
                txtIdM.Text = dgvMediciF.CurrentRow.Cells[0].Value.ToString();
                vm.IdUtil = Convert.ToInt32(txtIdM.Text);
                vm3.IdUtilF = Convert.ToInt32(txtIdM.Text);
                txtRolM.Text = dgvMediciF.CurrentRow.Cells[1].Value.ToString();
                vm.RolUtil = txtRolM.Text;
                txtEmailM.Text = dgvMediciF.CurrentRow.Cells[2].Value.ToString();
                vm.EmailUtil = txtEmailM.Text;
                txtParolaM.Text = dgvMediciF.CurrentRow.Cells[3].Value.ToString();
                vm.ParolaUtil = txtParolaM.Text;
                txtOraStartM.Text = dgvMediciF.CurrentRow.Cells[4].Value.ToString();
                vm.OraStartMed = Convert.ToInt32(txtOraStartM.Text);
                txtOraStopM.Text = dgvMediciF.CurrentRow.Cells[5].Value.ToString();
                vm.OraStopMed = Convert.ToInt32(txtOraStopM.Text);
                //txtCipAF.Text = txtCipA.Text;
                //txtSpecieAF.Text = txtSpecieA.Text;
                //txtIdMF.Text = txtIdM.Text;
            }
        }

        private void dgvAnimaleF_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAnimaleF.CurrentRow.Index != -1)
            {
                txtCipA.Text = dgvAnimaleF.CurrentRow.Cells[0].Value.ToString();
                vm2.CipAnim = Convert.ToInt32(txtCipA.Text);
                vm3.CipAnimF = Convert.ToInt32(txtCipA.Text); 
                txtSpecieA.Text = dgvAnimaleF.CurrentRow.Cells[1].Value.ToString();
                vm2.SpecieAnim = txtSpecieA.Text;
                vm3.SpecieAnimF = txtSpecieA.Text;
                //txtCipAF.Text = txtCipA.Text;
                //txtSpecieAF.Text = txtSpecieA.Text;
                //txtIdMF.Text = txtIdM.Text;
            }
        }

        private void btnAdaugareFisa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtOraF.Text) >= Convert.ToInt32(txtOraStartM.Text) && Convert.ToInt32(txtOraF.Text) <= Convert.ToInt32(txtOraStopM.Text))
            {
                vm3.CreareFisaC.Executa();
                vm3.VizualizareFisaC.Executa();
                vm2.StergereC.Executa();
                vm2.VizualizareC.Executa();
            }
            else MessageBox.Show("Oranu se afla in programul de lucru al doctorului ales!! Alegeti o ora potrivita!!");

        }

        private void btnAlege_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNrCrtF_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtZiuaF_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtOraF_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSimptomF_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDiagnosticF_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTratamentF_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void VAsistentPlanificareConsultatii_Click(object sender, EventArgs e)
        {
            
        }
    }
}
