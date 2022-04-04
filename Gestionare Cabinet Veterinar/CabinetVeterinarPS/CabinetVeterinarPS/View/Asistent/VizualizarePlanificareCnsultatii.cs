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

namespace CabinetVeterinarPS.View.Asistent
{
    public partial class VizualizarePlanificareCnsultatii : Form, IVizualizarePlanificareConsultatii
    {
        public VizualizarePlanificareCnsultatii()
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

        public int NrCrt 
        {
            get
            {
                return Int32.Parse(this.txtNrCRT.Text);
            }
            set
            {
                this.txtNrCRT.Text = value.ToString();
            }
        }
        public int AnimalCIP 
        {
            get
            {
                return Int32.Parse(this.txtCIP.Text);
            }
            set
            {
                this.txtCIP.Text = value.ToString();
            }
        }
        public int MedCons 
        {
            get
            {
                return Int32.Parse(this.txtMedic.Text);
            }
            set
            {
                this.txtMedic.Text = value.ToString();
            }
        }
        public string ZiuaCons 
        {
            get
            {
                return this.txtZi.Text;
            }
            set
            {
                this.txtZi.Text = value;
            }
        }
        public int OraCons 
        {
            get
            {
                return Int32.Parse(this.txtOra.Text);
            }
            set
            {
                this.txtOra.Text = value.ToString();
            }
        }
        public List<string[]> ListaFiseMedicale 
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareAsistent v = new VizualizareAsistent();
            v.Show();
        }

        private void VizualizarePlanificareCnsultatii_Load(object sender, EventArgs e)
        {

        }

        private void btnAdaugaFisa_Click(object sender, EventArgs e)
        {
            PrezentareFisaMedicala pp = new PrezentareFisaMedicala(this);
            pp.Adaugare();
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            PrezentareFisaMedicala pp = new PrezentareFisaMedicala(this);
            pp.Lista();
        }
    }
}
