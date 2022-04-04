using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetVeterinarPS.Model;
using CabinetVeterinarPS.Model.Persistenta;
using CabinetVeterinarPS.View.Asistent;

namespace CabinetVeterinarPS.Presenter
{
    class PrezentareFisaMedicala
    {
        IVizualizarePlanificareConsultatii viz;
        PersistentaFisaMedicala persistenta;

        public PrezentareFisaMedicala(IVizualizarePlanificareConsultatii viz)
        {
            this.viz = viz;
            this.persistenta = new PersistentaFisaMedicala();
        }


        public void Lista()
        {
            List<string[]> listaFiseMedicale = new List<string[]>();
            foreach (FisaMedicala u in this.persistenta.GetListaFiseMedicale())
            {
                listaFiseMedicale.Add(u.ConversieFisa());
            }
            this.viz.ListaFiseMedicale = listaFiseMedicale;
        }
        public void Cautare()
        {
            List<string[]> listaFise = new List<string[]>();
            foreach (FisaMedicala u in this.persistenta.GetListaFiseMedicale())
            {
                if (this.viz.NrCrt == u.NrCrt)
                {
                    listaFise.Add(u.ConversieFisa());
                }
            }
            this.viz.ListaFiseMedicale = listaFise;
        }

        public void CautareDupaMedic()
        {
            List<string[]> listaFise = new List<string[]>();
            foreach (FisaMedicala u in this.persistenta.GetListaFiseMedicale())
            {
                if (this.viz.MedCons == u.Consult.Medic)
                {
                    listaFise.Add(u.ConversieFisa());
                }
            }
            this.viz.ListaFiseMedicale = listaFise;
        }


        public bool Adaugare()
        {
            if (this.viz.NrCrt.ToString() == "")
            {
                MessageBox.Show("Trebuie sa introduceti si Nr Crt-ul!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viz.AnimalCIP.ToString() == "")
            {
                MessageBox.Show("Trebuie sa introduceti si cip!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viz.MedCons.ToString() == "")
            {
                MessageBox.Show("Trebuie sa introduceti si medicul!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viz.ZiuaCons == "")
            {
                MessageBox.Show("Trebuie sa introduceti si cip!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viz.OraCons.ToString() == "")
            {
                MessageBox.Show("Trebuie sa introduceti si cip!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (this.viz.NrCrt.ToString() != "" && this.viz.AnimalCIP.ToString() != "" && this.viz.MedCons.ToString() != "" && this.viz.ZiuaCons != "" && this.viz.OraCons.ToString() != "")
            {

                Animal a = new Animal(this.viz.AnimalCIP.ToString());
                Consultatie c = new Consultatie(this.viz.MedCons, this.viz.ZiuaCons, this.viz.OraCons);
                FisaMedicala fisa = new FisaMedicala(this.viz.NrCrt, a, c);
                bool succes = this.persistenta.AdaugareFisaMedicala(fisa);
                return succes;
            }
            else
            {
                MessageBox.Show("EROARE LA INTRODUCERE DATE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Stergere()
        {
            if (this.viz.Selectie != null)
            {
                var confirmare = MessageBox.Show("Doriti intr-adevar stergerea animalul selectat?",
                    "STERGERE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmare == DialogResult.Yes)
                {
                    bool succes = this.persistenta.StergereFisaMedicala(this.viz.Selectie);
                    if (!succes)
                        MessageBox.Show("EROARE LA STERGERE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return succes;
                }
                else
                    return false;
            }
            else
            {
                MessageBox.Show("Nu s-a selectat niciun animal", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Actualizare()
        {
            if (this.viz.Selectie != null)
            {

                var confirmare = MessageBox.Show("Doriti intr-adevar actualizarea animalul selectat?",
                    "ACTUALIZARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Animal a = new Animal(this.viz.AnimalCIP.ToString());
                Consultatie c = new Consultatie(this.viz.MedCons, this.viz.ZiuaCons, this.viz.OraCons);
                FisaMedicala fisa = new FisaMedicala(this.viz.NrCrt, a, c);
                if (confirmare == DialogResult.Yes)
                {
                    bool succes = this.persistenta.ActualizareFisaMedicala(this.viz.Selectie, fisa);
                    if (!succes)
                        MessageBox.Show("EROARE LA ACTUALIZARE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return succes;
                }
                else
                    return false;
            }
            else
            {
                MessageBox.Show("Nu s-a selectat niciun animal", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void CSV()
        {
            persistenta.FisierCSV();
        }
        public void JSON()
        {
            persistenta.FisierJSON();
        }
    }
}
