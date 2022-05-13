using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EllipticCurve.Utils;
using Tema2PS.Model;
using Tema2PS.Model.Persistenta;

namespace Tema2PS.View.ViewAsistent
{
    public partial class VVizualizareStatistici : Form
    {
        public VVizualizareStatistici()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAsistent v = new VAsistent();
            v.Show();
        }

        private void VVizualizareStatistici_Load(object sender, EventArgs e)
        {
            PersistentaFisaMed p = new PersistentaFisaMed();
            List<FisaMedicala> l = p.LisaFise();
            int[] nr = new int[10];
            for (int i = 0; i < l.Count(); i++)
            {
                if (l[i].Specie == "felina")
                    nr[0]++;
                else if (l[i].Specie == "canin")
                    nr[1]++;
                else if (l[i].Specie == "rozatoare")
                    nr[2]++;
                else if (l[i].Specie == "pasare")
                    nr[3]++;
                else if (l[i].Specie == "peste")
                    nr[4]++;
                else if (l[i].Specie == "reptila")
                    nr[5]++;
                else if (l[i].Specie == "paianjen")
                    nr[6]++;
            }
            chart1.Series["Specie"].Points.AddXY("felina", nr[0]);
            chart1.Series["Specie"].Points.AddXY("canin", nr[1]);
            chart1.Series["Specie"].Points.AddXY("rozatoare", nr[2]);
            chart1.Series["Specie"].Points.AddXY("pasare", nr[3]);
            chart1.Series["Specie"].Points.AddXY("peste", nr[4]);
            chart1.Series["Specie"].Points.AddXY("reptila", nr[5]);
            chart1.Series["Specie"].Points.AddXY("paianjen", nr[6]);


            int[] nr2 = new int[10];
            for (int i = 0; i < l.Count(); i++)
            {
                if (l[i].Diagnostic == "Raceala")
                    nr2[0]++;
                else if (l[i].Diagnostic == "Gripa")
                    nr2[1]++;
                else if (l[i].Diagnostic == "PIF")
                    nr2[2]++;
                else if (l[i].Diagnostic == "Pesta")
                    nr2[3]++;
                else if (l[i].Diagnostic == "Tuberculoza")
                    nr2[4]++;
                else if (l[i].Diagnostic == "Bluetongue")
                    nr2[5]++;
                else if (l[i].Diagnostic == "Trichineloza")
                    nr2[6]++;
            }
            chart2.Series["Diagnostic"].Points.AddXY("Raceala", nr2[0]);
            chart2.Series["Diagnostic"].Points.AddXY("Gripa", nr2[1]);
            chart2.Series["Diagnostic"].Points.AddXY("PIF", nr2[2]);
            chart2.Series["Diagnostic"].Points.AddXY("Pesta", nr2[3]);
            chart2.Series["Diagnostic"].Points.AddXY("Tuberculoza", nr2[4]);
            chart2.Series["Diagnostic"].Points.AddXY("Bluetongue", nr2[5]);
            chart2.Series["Diagnostic"].Points.AddXY("Trichineloza", nr2[6]);
        }
    }
}
