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
    class PrezentareAnimal
    {
        IVizualizareGestionareAnimale viz;
        PersistentaAnimal persistenta;

        public PrezentareAnimal(IVizualizareGestionareAnimale viz)
        {
            this.viz = viz;
            this.persistenta = new PersistentaAnimal();
        }


        public void Lista()
        {
            List<string[]> listaAnimale = new List<string[]>();
            foreach (Animal u in this.persistenta.GetListaAnimale())
            {
                listaAnimale.Add(u.Conversie());
            }
            this.viz.ListaAnimale = listaAnimale;
        }
        public void Cautare()
        {
            List<string[]> listaAnimale = new List<string[]>();
            foreach (Animal u in this.persistenta.GetListaAnimale())
            {
                if (this.viz.Specie == u.Specie)
                {
                    listaAnimale.Add(u.Conversie());
                }
            }
            this.viz.ListaAnimale = listaAnimale;
        }

        public bool Adaugare()
        {
            if (this.viz.Cip == "")
            {
                MessageBox.Show("Trebuie sa introduceti si Cip-ul!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viz.Selectie == "")
            {
                MessageBox.Show("Trebuie sa introduceti si specia!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viz.Cip != "" && this.viz.Specie != "")
            {

                Animal animal = new Animal(this.viz.Cip, this.viz.Specie);
                bool succes = this.persistenta.AdaugareAnimal(animal);
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
                    bool succes = this.persistenta.StergereAnimal(this.viz.Selectie);
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
               this.viz.Cip = "";
                Animal animal = new Animal(this.viz.Cip, this.viz.Specie);

                if (confirmare == DialogResult.Yes)
                {
                    bool succes = this.persistenta.ActualizareAnimal(this.viz.Selectie, animal);
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
