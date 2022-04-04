using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetVeterinarPS.Model;
using CabinetVeterinarPS.Model.Persistenta;
using CabinetVeterinarPS.View.Asistent;
using CabinetVeterinarPS.View.Medic;

namespace CabinetVeterinarPS.Presenter
{
    class PrezentareGestionareFiseMedicaleMedic
    {
        IVizualizareGestionareFiseMedicale viz;
        PersistentaFisaMedicala persistenta;
        IVizualizarePlanificareConsultatii viz2;

        public PrezentareGestionareFiseMedicaleMedic(IVizualizareGestionareFiseMedicale viz)
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
            this.viz.ListaAnimale = listaFiseMedicale;
        }

        public bool Actualizare()
        {
            if (this.viz.Selectie != null)
            {

                var confirmare = MessageBox.Show("Doriti intr-adevar actualizarea animalul selectat?",
                    "ACTUALIZARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Animal a = new Animal();
                Consultatie c = new Consultatie(this.viz.Simptome, this.viz.Diagnostic, this.viz.Tratament);
                FisaMedicala fisa = new FisaMedicala(a, c);
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
    }
}
