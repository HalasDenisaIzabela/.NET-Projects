using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetVeterinarPS.Presenter;

namespace CabinetVeterinarPS.View.Medic
{
    public partial class VizualizareFiltrareAnimale : Form, IVizualizareFiltrareAnimaleMedic
    {
        public string Diagnostic
        {
            get
            {
                if (this.txtDiagnostic.Text == "")
                    return "";
                else
                    return this.txtDiagnostic.Text;
            }
            set
            {
                this.txtDiagnostic.Text = value;
            }
        }
        public string Tratament
        {
            get
            {
                return this.txtTratament.Text;
            }
            set
            {
                this.txtTratament.Text = value;
            }
        }

        public List<string[]> ListaAnimale
        {
            set
            {
                this.listView1.Items.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    ListViewItem rand;
                    rand = this.listView1.Items.Add(value[i][0]);
                    rand.SubItems.Add(value[i][1]);
                    rand.SubItems.Add(value[i][2]);
                    rand.SubItems.Add(value[i][3]);
                    rand.SubItems.Add(value[i][4]);
                    rand.SubItems.Add(value[i][5]);
                    rand.SubItems.Add(value[i][6]);
                    rand.SubItems.Add(value[i][7]);
                }
            }
        }

        public string Selectie
        {
            get
            {
                if (listView1.SelectedItems.Count > 0)
                    return listView1.SelectedItems[0].SubItems[0].Text;
                else
                    return null;
            }
        }
        public VizualizareFiltrareAnimale()
        {
            InitializeComponent();
            listView1.View = System.Windows.Forms.View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nr.Crt.", 70);
            listView1.Columns.Add("Cip", 70);
            listView1.Columns.Add("Medic", 70);
            listView1.Columns.Add("Ziua", 110);
            listView1.Columns.Add("Ora", 100);
            listView1.Columns.Add("Simptome", 100);
            listView1.Columns.Add("Diagnostic", 100);
            listView1.Columns.Add("Tratament", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareMedic v = new VizualizareMedic();
            v.Show();
        }

        private void VizualizareFiltrareAnimale_Load(object sender, EventArgs e)
        {

        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            PrezentareFiltrareAnimaleMedic pp = new PrezentareFiltrareAnimaleMedic(this);
            pp.CautareDiagnostic();
        }

        private void btnTratament_Click(object sender, EventArgs e)
        {
            PrezentareFiltrareAnimaleMedic pp = new PrezentareFiltrareAnimaleMedic(this);
            pp.CautareTratament();
        }
    }
}
