using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace CabinetVeterinarPS.Model.Persistenta
{
    class PersistentaFisaMedicala
    {
        private List<FisaMedicala> fiseMedicale;
        PersistentaAnimal pa;
        PersistentaMedic pm;

        public PersistentaFisaMedicala()
        {
            this.fiseMedicale = new List<FisaMedicala>();
            this.citireXML();
            this.pa = new PersistentaAnimal();
            this.pm = new PersistentaMedic();
            pa.GetListaAnimale();
            pm.GetListaMedici();
        }


        public List<FisaMedicala> GetListaFiseMedicale()
        {
            return this.fiseMedicale;
        }

        private bool existaAnimal(FisaMedicala fis)
        {
            bool gasit = false;
            int i = 0;
            while (i < this.pa.animale.Count && !gasit)
            {
                Animal m = new Animal(this.pa.animale[i]);
                if (fis.Anim.Cip == m.Cip)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }

        private bool existaMedic(FisaMedicala fis)
        {
            bool gasit = false;
            int i = 0;
            while (i < this.pm.medici.Count && !gasit)
            {
                Medic m = new Medic(this.pm.medici[i]);
                if (fis.Consult.Medic == m.Id)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }
        public bool AdaugareFisaMedicala(FisaMedicala fis)
        {
            bool succes = true;

            if (this.fiseMedicale.Count == 0 || !this.exista(fis))
            {
                if (this.existaAnimal(fis) && existaMedic(fis))
                {
                    this.fiseMedicale.Add(fis);
                    try
                    {
                        FileStream fs = new FileStream("FiseMedicale.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<FisaMedicala>));
                            xs.Serialize(fs, this.fiseMedicale);
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
                else succes = false;
            }
            else
                succes = false;
            return succes;
        }

        private bool exista(FisaMedicala fis)
        {
            bool gasit = false;
            int i = 0;
            while (i < this.fiseMedicale.Count && !gasit)
            {
                FisaMedicala m = new FisaMedicala(this.fiseMedicale[i]);
                if (fis == m)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }

        public bool StergereFisaMedicala(string nume)
        {
            bool succes = false;
            int pozitie = 0;
            while (pozitie < this.fiseMedicale.Count && !succes)
            {
                FisaMedicala m = new FisaMedicala(this.fiseMedicale[pozitie]);
                if (Equals(nume, m.NrCrt.ToString()))
                {
                    succes = true;
                    this.fiseMedicale.RemoveAt(pozitie);
                    //this.utilizatori.RemoveAt();
                    //this.utilizatori.Insert()
                    try
                    {
                        FileStream fs = new FileStream("FiseMedicale.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<FisaMedicala>));
                            xs.Serialize(fs, this.fiseMedicale);
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
        public bool ActualizareFisaMedicala(string nume, FisaMedicala fis)
        {
            bool succes1 = false;
            int pozitie = 0;

            while (pozitie < this.fiseMedicale.Count && !succes1)
            {
                FisaMedicala m = new FisaMedicala(this.fiseMedicale[pozitie]);
                if (Equals(nume, m.NrCrt.ToString()))
                {
                    succes1 = true;
                    this.fiseMedicale.RemoveAt(pozitie);
                    //this.utilizatori.Add(util);
                    this.fiseMedicale.Insert(pozitie, fis);
                    try
                    {
                        FileStream fs = new FileStream("FiseMedicale.xml", FileMode.Create);
                        try
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<FisaMedicala>));
                            xs.Serialize(fs, this.fiseMedicale);
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
            foreach (FisaMedicala p in this.fiseMedicale)
                s += p.ToString();
            return s;
        }

        private void citireXML()
        {
            try
            {
                FileStream fs = new FileStream("FiseMedicale.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<FisaMedicala>));
                    this.fiseMedicale = (List<FisaMedicala>)xs.Deserialize(fs);
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
                this.fiseMedicale = null;
            }
        }

        public void FisierCSV()
        {
            foreach (var a in fiseMedicale)
            {
                File.AppendAllText("FiseMedicale.csv", $"{a.NrCrt}, {a.Anim.Cip}, {a.Consult.Medic}, {a.Consult.Ora}, {a.Consult.Ziua}, {a.Consult.Simptome}, {a.Consult.Diagnostic}, {a.Consult.Tratament}\n");
            }
        }
        public void FisierJSON()
        {
            foreach (var a in fiseMedicale)
            {
                string strResultJSON = JsonSerializer.Serialize(a);
                File.WriteAllText("..\\..\\FiseMedicale.json", strResultJSON);
            }
        }
    }
}
