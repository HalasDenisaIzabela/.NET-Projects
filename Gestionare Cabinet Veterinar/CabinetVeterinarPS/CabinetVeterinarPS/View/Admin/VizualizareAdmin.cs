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
using CabinetVeterinarPS.View.Admin;

namespace CabinetVeterinarPS.View
{
    public partial class VizualizareAdmin : Form, IVizualizareAdmin
    {
        public VizualizareAdmin()
        {
            InitializeComponent();
            listaUtilizatori.View = System.Windows.Forms.View.Details;
            listaUtilizatori.GridLines = true;
            listaUtilizatori.FullRowSelect = true;
            listaUtilizatori.Columns.Add("Rol", 150);
            listaUtilizatori.Columns.Add("Email", 150);
            listaUtilizatori.Columns.Add("Parola", 150);
        }
        public string Rol
        {
            get
            {
                /*if (this.txtRol.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus rolul", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else*/
                    return this.txtRol.Text;
            }
            set
            {
                this.txtRol.Text = value;
            }
        }
        public string Email
        {
            get
            {
                /*if (this.txtEmail.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus email-ul", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else*/
                    return this.txtEmail.Text;
            }
            set
            {
                this.txtEmail.Text = value;
            }
        }
        public string Parola
        {
            get
            {
                /*if (this.txtParola.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus parola", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else*/
                    return this.txtParola.Text;
            }
            set
            {
                this.txtParola.Text = value;
            }
        }
        public int Id
        {
            get
            {
                if (this.txtId.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus Id", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.txtId.Text);
            }
            set
            {
                this.txtId.Text = value.ToString();
            }
        }
        public List<string[]> ListaUtilizatori
        {
            set
            {
                this.listaUtilizatori.Items.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    ListViewItem rand;
                    rand = this.listaUtilizatori.Items.Add(value[i][0]);
                    rand.SubItems.Add(value[i][1]);
                    rand.SubItems.Add(value[i][2]);
                }
            }
        }        

        public string Selectie
        {
            get
            {
                if (listaUtilizatori.SelectedItems.Count > 0)
                    return listaUtilizatori.SelectedItems[0].SubItems[1].Text;
                else
                    return null;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            PrezentareUtilizator pp = new PrezentareUtilizator(this);
            pp.Actualizare();
        }

        private void btnCitire_Click(object sender, EventArgs e)
        {
            PrezentareUtilizator pp = new PrezentareUtilizator(this);
            pp.Cautare();
        }

        private void VizualizareAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnCreare_Click(object sender, EventArgs e)
        {
            PrezentareUtilizator pp = new PrezentareUtilizator(this);
            pp.Adaugare();
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            PrezentareUtilizator pp = new PrezentareUtilizator(this);
            pp.Lista();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            PrezentareUtilizator pp = new PrezentareUtilizator(this);
            pp.Stergere();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareAutentificare v = new VizualizareAutentificare();
            v.Show();
        }
    }
}
