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
    class PersistentaAnimal
    {
        public List<Animal> animale;

        public PersistentaAnimal()
        {
            this.animale = new List<Animal>();
            this.citireXML();
        }

        public List<Animal> GetListaAnimale()
        {
            return this.animale;
        }
        public bool AdaugareAnimal(Animal a)
        {
            bool succes = true;

            if (this.animale.Count == 0 || !this.exista(a))
            {
                this.animale.Add(a);
                try
                {
                    FileStream fs = new FileStream("Animale.xml", FileMode.Create);
                    try
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(List<Animal>));
                        xs.Serialize(fs, this.animale);
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

        private bool exista(Animal animal)
        {
            bool gasit = false;
            int i = 0;
            while (i < this.animale.Count && !gasit)
            {
                Animal a = new Animal(this.animale[i]);
                if (animal == a)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }

        public bool StergereAnimal(string nume)
        {
            bool succes = false;
            int pozitie = 0;
            while (pozitie < this.animale.Count && !succes)
            {
                Animal a = new Animal(this.animale[pozitie]);
                if (Equals(nume, a.Cip))
                {
                    succes = true;
                    this.animale.RemoveAt(pozitie);
                    //this.utilizatori.RemoveAt();
                    //this.utilizatori.Insert()
                    try
                    {
                        FileStream fs = new FileStream("Animale.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<Animal>));
                            xs.Serialize(fs, this.animale);
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
        public bool ActualizareAnimal(string nume, Animal anim)
        {
            bool succes1 = false;
            int pozitie = 0;

            while (pozitie < this.animale.Count && !succes1)
            {
                Animal a = new Animal(this.animale[pozitie]);
                if (Equals(nume, a.Cip))
                {
                    succes1 = true;
                    anim.Cip = a.Cip;
                    this.animale.RemoveAt(pozitie);
                    //this.utilizatori.Add(util);
                    this.animale.Insert(pozitie, anim);
                    try
                    {
                        FileStream fs = new FileStream("Animale.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<Animal>));
                            xs.Serialize(fs, this.animale);
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
            foreach (Animal p in this.animale)
                s += p.ToString();
            return s;
        }

        private void citireXML()
        {
            try
            {
                FileStream fs = new FileStream("Animale.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Animal>));
                    this.animale = (List<Animal>)xs.Deserialize(fs);
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
                this.animale = null;
            }
        }

        public void FisierCSV()
        {
            foreach (var a in animale)
            {
                File.WriteAllText("Animale.csv", $"{a.Cip}, {a.Specie}\n");
            }
        }
        public void FisierJSON()
        {
            foreach (var a in animale)
            {
                File.WriteAllText("Animale.json", $"{a.Cip}, {a.Specie}\n");
            }
        }
    }
}
