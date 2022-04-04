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
    public partial class VizualizareGestionareProgram : Form, IVizualizareGestionareProgram
    {
        public VizualizareGestionareProgram()
        {
            InitializeComponent();
            listView1.View = System.Windows.Forms.View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Id", 70);
            listView1.Columns.Add("L start", 50);
            listView1.Columns.Add("L Stop", 50);
            listView1.Columns.Add("Ma Start", 50);
            listView1.Columns.Add("Ma Stop", 50);
            listView1.Columns.Add("Mi start", 50);
            listView1.Columns.Add("Mi Stop", 50);
            listView1.Columns.Add("J Start", 50);
            listView1.Columns.Add("J Stop", 50);
            listView1.Columns.Add("V start", 50);
            listView1.Columns.Add("V Stop", 50);

        }

        public int LuniOraStart 
        {
            get
            {
                if (this.lunistart.Text.Length == 0 || (Int32.Parse(this.lunistart.Text) < 7 && Int32.Parse(this.lunistart.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora start luni", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.lunistart.Text);
            }
            set
            {
                this.lunistart.Text = value.ToString();
            }
        }
        public int LuniOraSop 
        {
            get
            {
                if (this.lunistop.Text.Length == 0 || (Int32.Parse(this.lunistop.Text) < Int32.Parse(this.lunistart.Text) && Int32.Parse(this.lunistop.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora stop luni", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.lunistop.Text);
            }
            set
            {
                this.lunistop.Text = value.ToString();
            }
        }
        public int MartiOraStart 
        {
            get
            {
                if (this.martistart.Text.Length == 0 || (Int32.Parse(this.martistart.Text) < 7 && Int32.Parse(this.martistart.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora start marti", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.martistart.Text);
            }
            set
            {
                this.martistart.Text = value.ToString();
            }
        }
        public int MartiOraSop 
        {
            get
            {
                if (this.martistop.Text.Length == 0 || (Int32.Parse(this.martistop.Text) < Int32.Parse(this.martistart.Text) && Int32.Parse(this.martistop.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora stop marti", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.martistop.Text);
            }
            set
            {
                this.martistop.Text = value.ToString();
            }
        }
        public int MiercuriOraStart 
        {
            get
            {
                if (this.miercuristart.Text.Length == 0 || (Int32.Parse(this.miercuristart.Text) < 7 && Int32.Parse(this.miercuristart.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora start miercuri", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.miercuristart.Text);
            }
            set
            {
                this.miercuristart.Text = value.ToString();
            }
        }
        public int MiercuriOraSop 
        {
            get
            {
                if (this.miercuristop.Text.Length == 0 || (Int32.Parse(this.miercuristop.Text) < Int32.Parse(this.miercuristart.Text) && Int32.Parse(this.miercuristop.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora stop miercuri", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.miercuristop.Text);
            }
            set
            {
                this.miercuristop.Text = value.ToString();
            }
        }
        public int JoiOraStart 
        {
            get
            {
                if (this.joistart.Text.Length == 0 || (Int32.Parse(this.joistart.Text) < 7 && Int32.Parse(this.joistart.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora start joi", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.joistart.Text);
            }
            set
            {
                this.joistart.Text = value.ToString();
            }
        }
        public int JoiOraSop 
        {
            get
            {
                if (this.joistop.Text.Length == 0 || (Int32.Parse(this.joistop.Text) < Int32.Parse(this.joistart.Text) && Int32.Parse(this.joistop.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora stop joi", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.joistop.Text);
            }
            set
            {
                this.joistop.Text = value.ToString();
            }
        }
        public int VineriOraStart 
        {
            get
            {
                if (this.vineristart.Text.Length == 0 || (Int32.Parse(this.vineristart.Text) < 7 && Int32.Parse(this.vineristart.Text) > 24))
                {
                    MessageBox.Show("Nu s-a introdus corect ora start vineri", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.vineristart.Text);
            }
            set
            {
                this.vineristart.Text = value.ToString();
            }
        }
        public int VineriOraSop 
        {
            get
            {
                if (Int32.Parse(this.vineristop.Text) < Int32.Parse(this.vineristart.Text) && Int32.Parse(this.vineristop.Text) > 24)
                {
                    MessageBox.Show("Nu s-a introdus corect ora stop vineri", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                if (this.vineristop.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus corect ora stop vineri", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return Int32.Parse(this.vineristop.Text);
            }
            set
            {
                this.vineristop.Text = value.ToString();
            }
        }
        public List<string[]> ListaMedici {
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
                    rand.SubItems.Add(value[i][8]); 
                    rand.SubItems.Add(value[i][9]);
                    rand.SubItems.Add(value[i][10]);

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
            VizualizareMedic v = new VizualizareMedic();
            v.Show();
        }

        private void VizualizareGestionareProgram_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            PrezentareMedic pp = new PrezentareMedic(this);
            pp.Lista();
        }

        private void btnCreare_Click(object sender, EventArgs e)
        {
            PrezentareMedic pp = new PrezentareMedic(this);
            pp.ActualizareMedic();
        }
    }
}
