using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2PS.View.ViewMedic
{
    public partial class VMedic : Form
    {
        public VMedic()
        {
            InitializeComponent();
        }

        /*private void btnGestProgram_Click(object sender, EventArgs e)
        {
            VizualizareGestionareProgram v = new VizualizareGestionareProgram();
            this.Hide();
            v.Show();

        }

        private void btnFiltrareAnimale_Click(object sender, EventArgs e)
        {
            VizualizareFiltrareAnimale v = new VizualizareFiltrareAnimale();
            this.Hide();
            v.Show();
        }

        private void btnGestFise_Click(object sender, EventArgs e)
        {
            VizualizareGestionareFiseMedicale v = new VizualizareGestionareFiseMedicale();
            this.Hide();
            v.Show();
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void VMedic_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                this.Hide();
                Logare v = new Logare();
                v.Show();
        }

        private void btnGestProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
            VGestionareProgramMedic v = new VGestionareProgramMedic();
            v.Show();
        }

        private void btnGestFise_Click(object sender, EventArgs e)
        {
            this.Hide();
            VGestionareFiseMedicaleMedic v = new VGestionareFiseMedicaleMedic();
            v.Show();
        }

        private void btnFiltrareAnimale_Click(object sender, EventArgs e)
        {
            this.Hide();
            VFiltrareAnimaleMedic v = new VFiltrareAnimaleMedic();
            v.Show();
        }
    }
}
