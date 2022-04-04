using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using CabinetVeterinarPS.View;

namespace CabinetVeterinarPS
{
    public partial class VizualizareAutentificare : Form
    {
        public VizualizareAutentificare()
        {
            InitializeComponent();
        }

        public string FromXML_rol = "";
        public string FromXML_email = "";
        public string FromXML_parola = "";

        private void VizualizareAutentificare_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string parola = txtParola.Text;

            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\Utilizatorii.xml");
            var selected_users = from x in doc.Descendants("Utilizator").Where
                                 (x => (string)x.Element("Email") == txtEmail.Text)
                                 select new
                                 {
                                     XMLRol = x.Element("Rol").Value,
                                     XMLEmail = x.Element("Email").Value,
                                     XMLParola = x.Element("Parola").Value
                                 };
            foreach (var x in selected_users)
            {
                FromXML_rol = x.XMLRol;
                FromXML_email = x.XMLEmail;
                FromXML_parola = x.XMLParola;
            }
            if (email == FromXML_email)
            {
                if(parola == FromXML_parola)
                {
                    VizualizareAdmin mergiLaFereastraAdmin = new VizualizareAdmin();
                    VizualizareMedic mergiLaFereastraMedic = new VizualizareMedic();
                    VizualizareAsistent mergiLaFereastraAsistent = new VizualizareAsistent();

                    //MessageBox.Show("Corect!!");
                    if (FromXML_rol == "admin")
                    {
                        
                        ClearBoxes();
                        this.Hide();
                        mergiLaFereastraMedic.Hide();
                        mergiLaFereastraAsistent.Hide();
                        mergiLaFereastraAdmin.Show();
                    }
                    else if(FromXML_rol == "dr")
                    {
                        ClearBoxes();
                        this.Hide();
                        mergiLaFereastraAsistent.Hide();
                        mergiLaFereastraAdmin.Hide();
                        mergiLaFereastraMedic.Show();
                        
                    }
                    else if (FromXML_rol == "asistent")
                    {
                        ClearBoxes();
                        this.Hide();
                        mergiLaFereastraAdmin.Hide();
                        mergiLaFereastraMedic.Hide(); 
                        mergiLaFereastraAsistent.Show();
                    }
                    else MessageBox.Show("Utilizatorul care incearca sa se autentifice nu este admin, medic sau asistent!");


                }
                else
                {
                    MessageBox.Show("Parola incorect!!");
                    ClearBoxes();
                }
            }
            else
            {
                MessageBox.Show("Email incorect!!");
                ClearBoxes();
            }
        }

        private void ClearBoxes()
        {
            txtEmail.Clear();
            txtParola.Clear();
        }
    }
}
