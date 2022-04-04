using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CabinetVeterinarPS.Model.Persistenta
{
    class PersistentaMedic
    {
        public List<Medic> medici;

        public PersistentaMedic()
        {
            this.medici = new List<Medic>();
            this.citireXML();
        }

        public List<Medic> GetListaMedici()
        {
            return this.medici;
        }
        public bool AdaugareMedic(Medic m)
        {
            bool succes = true;
            if (this.medici.Count == 0 || !this.exista(m))
            {
                this.medici.Add(m);
                
                try
                {
                    FileStream fs = new FileStream("Medici.xml", FileMode.Create);
                    try
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(List<Medic>));
                        xs.Serialize(fs, this.medici);
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

        private bool exista(Medic medic)
        {
            bool gasit = false;
            int i = 0;
            while (i < this.medici.Count && !gasit)
            {
                Medic m = new Medic(this.medici[i]);
                if (medic == m)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }

        public bool StergereMedic(string nume)
        {
            bool succes = false;
            int pozitie = 0;
            while (pozitie < this.medici.Count && !succes)
            {
                Medic m = new Medic(this.medici[pozitie]);
                if (Equals(nume, m.Id.ToString()))
                {
                    succes = true;
                    this.medici.RemoveAt(pozitie);
                    //this.utilizatori.RemoveAt();
                    //this.utilizatori.Insert()
                    try
                    {
                        FileStream fs = new FileStream("Medici.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<Medic>));
                            xs.Serialize(fs, this.medici);
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
        public bool ActualizareMedic(string nume, Medic med)
        {
            //bool succes1 = StergereMedic(nume);
            //bool succes2 = AdaugareMedic(med);
            //return succes2;
           bool succes1 = false;
            int pozitie = 0;

            while (pozitie < this.medici.Count && !succes1)
            {
                Medic m = new Medic(this.medici[pozitie]);
                if (Equals(nume, m.Id.ToString()))
                {
                    succes1 = true;
                    med.Id = m.Id;
                    this.medici.RemoveAt(pozitie);
                    this.medici.Insert(pozitie, med);
                    try
                    {
                        FileStream fs = new FileStream("Medici.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<Medic>));
                            xs.Serialize(fs, this.medici);
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
            foreach (Medic p in this.medici)
                s += p.ToString();
            return s;
        }

        private void citireXML()
        {
            try
            {
                FileStream fs = new FileStream("Medici.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Medic>));
                    this.medici = (List<Medic>)xs.Deserialize(fs);
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
                this.medici = null;
            }
        }

        public void FisierCSV()
        {
            foreach (var a in medici)
            {
                File.WriteAllText("Medici.csv", $"{a.Email}, {a.Id}\n");
            }
        }
        public void FisierJSON()
        {
            foreach (var a in medici)
            {
                File.WriteAllText("Medici.json", $"{a.Email}, {a.Id}\n");
            }
        }
    }
}
