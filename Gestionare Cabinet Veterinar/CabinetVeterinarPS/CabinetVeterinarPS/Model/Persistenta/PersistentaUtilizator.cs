using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CabinetVeterinarPS.Model.Persistenta
{
    class PersistentaUtilizator
    {
        private List<Utilizator> utilizatori;

        public PersistentaUtilizator()
        {
            this.utilizatori = new List<Utilizator>();
            this.citireXML();
        }

        public List<Utilizator> GetListaUtilizatori()
        {
            return this.utilizatori;
        }
        PersistentaMedic perMed;
        public bool AdaugareUtilizator(Utilizator u)
        {
            bool succes = true;

            if (this.utilizatori.Count == 0 || !this.exista(u))
            {
                this.utilizatori.Add(u);
                /*if(u.Rol == "dr")
                {
                    Medic m = new Medic(u.Rol, u.Email, u.Parola, index, null);
                    perMed.AdaugareMedic(m);
                    index++;
                }*/
                try
                {
                    FileStream fs = new FileStream("Utilizatorii.xml", FileMode.Create);
                    try
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(List<Utilizator>));
                        xs.Serialize(fs, this.utilizatori);
                    }
                    catch (SerializationException e)
                    {
                        MessageBox.Show("Eroare la serializare. Motiv: " + e.Message);
                        succes = false;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Eroare: " + e.Message);
                        succes = false;
                    }
                    finally
                    {
                        fs.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Eroare: " + e.Message);
                    succes = false;
                }
            }
            else
                succes = false;
            return succes;
        }

        private bool exista(Utilizator utilizator)
        {
            bool gasit = false;
            int i = 0;
            while (i < this.utilizatori.Count && !gasit)
            {
                Utilizator u = new Utilizator(this.utilizatori[i]);
                if (utilizator == u)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }

        public bool StergereUtilizator(string nume)
        {
            bool succes = false;
            int pozitie = 0;
            while (pozitie < this.utilizatori.Count && !succes)
            {
                Utilizator u = new Utilizator(this.utilizatori[pozitie]);
                if (Equals(nume, u.Email))
                    {
                        succes = true;
                    this.utilizatori.RemoveAt(pozitie);
                    //this.utilizatori.RemoveAt();
                    //this.utilizatori.Insert()
                    try
                    {
                        FileStream fs = new FileStream("Utilizatorii.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<Utilizator>));
                            xs.Serialize(fs, this.utilizatori);
                        }
                        catch (SerializationException e)
                        {
                            MessageBox.Show("Eroare la serializare. Motiv: " + e.Message);
                            succes = false;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Eroare: " + e.Message);
                            succes = false;
                        }
                        finally
                        {
                            fs.Close();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Eroare: " + e.Message);
                        succes = false;
                    }
                }
                else
                    pozitie++;
            }
            return succes;
        }
        public bool ActualizareUtilizator(string nume, Utilizator util)
        {
            bool succes1 = false;
            int pozitie = 0;

            while (pozitie < this.utilizatori.Count && !succes1)
            {
                Utilizator u = new Utilizator(this.utilizatori[pozitie]);
                if (Equals(nume, u.Email))
                {
                    succes1 = true;
                    util.Rol = u.Rol;
                    this.utilizatori.RemoveAt(pozitie);
                    //this.utilizatori.Add(util);
                    this.utilizatori.Insert(pozitie, util);
                    try
                    {
                        FileStream fs = new FileStream("Utilizatorii.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<Utilizator>));
                            xs.Serialize(fs, this.utilizatori);
                        }
                        catch (SerializationException e)
                        {
                            MessageBox.Show("Eroare la serializare. Motiv: " + e.Message);
                            succes1 = false;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Eroare: " + e.Message);
                            succes1 = false;
                        }
                        finally
                        {
                            fs.Close();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Eroare: " + e.Message);
                        succes1 = false;
                    }
                }
                else
                    pozitie++;
            }
            return succes1;
        }


        public override string ToString()
        {
            string s = "";
            foreach (Utilizator p in this.utilizatori)
                s += p.ToString();
            return s;
        }

        private void citireXML()
        {
            try
            {
                FileStream fs = new FileStream("Utilizatorii.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Utilizator>));
                    this.utilizatori = (List<Utilizator>)xs.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    MessageBox.Show("Eroare la deserializare. Motiv: " + e.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Eroare: " + e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Eroare: " + e.Message);
                this.utilizatori = null;
            }
        }

        public void FisierCSV()
        {
            foreach (var a in utilizatori)
            {
                File.WriteAllText("Utilizatorii.csv", $"{a.Rol}, {a.Email}, {a.Parola}\n");
            }
        }
        public void FisierJSON()
        {
            foreach (var a in utilizatori)
            {
                File.WriteAllText("Utilizatorii.json", $"{a.Rol}, {a.Email}, {a.Parola}\n");
            }
        }
    }
}
