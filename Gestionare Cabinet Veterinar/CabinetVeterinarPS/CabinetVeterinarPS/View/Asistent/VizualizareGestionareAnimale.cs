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
    public partial class VizualizareGestionareAnimale : Form, IVizualizareGestionareAnimale
    {
        public string Cip 
        { get
            {
                return this.txtCIP.Text;
            }
            set
            {
                this.txtCIP.Text = value;
            } 
        }
        public string Specie
        {
            get
            {
                return this.txtSpecie.Text;
            }
            set
            {
                this.txtSpecie.Text = value;
            }
        }
        public List<string[]> ListaAnimale
        {
            set
            {
                this.listaAnimale.Items.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    ListViewItem rand;
                    rand = this.listaAnimale.Items.Add(value[i][0]);
                    rand.SubItems.Add(value[i][1]);
                }
            }
        }

            public string Selectie
        {
            get
            {
                if (listaAnimale.SelectedItems.Count > 0)
                    return listaAnimale.SelectedItems[0].SubItems[0].Text;
                else
                    return null;
            }
        }
    

        public VizualizareGestionareAnimale()
        {
            InitializeComponent();
            listaAnimale.View = System.Windows.Forms.View.Details;
            listaAnimale.GridLines = true;
            listaAnimale.FullRowSelect = true;
            listaAnimale.Columns.Add("CIP", 250);
            listaAnimale.Columns.Add("Specie", 250);
        }

        private void VizualizareGestionareAnimale_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareAsistent v = new VizualizareAsistent();
            v.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listaAnimale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            PrezentareAnimal pp = new PrezentareAnimal(this);
            pp.Lista();
        }

        private void btnCitire_Click(object sender, EventArgs e)
        {
            PrezentareAnimal pp = new PrezentareAnimal(this);
            pp.Cautare();
        }

        private void btnCreare_Click(object sender, EventArgs e)
        {
            PrezentareAnimal pp = new PrezentareAnimal(this);
            pp.Adaugare();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            PrezentareAnimal pp = new PrezentareAnimal(this);
            pp.Actualizare();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            PrezentareAnimal pp = new PrezentareAnimal(this);
            pp.Stergere();
        }
    }
}
