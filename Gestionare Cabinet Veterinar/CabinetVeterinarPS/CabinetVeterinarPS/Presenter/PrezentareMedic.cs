using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetVeterinarPS.Model;
using CabinetVeterinarPS.Model.Persistenta;
using CabinetVeterinarPS.View.Medic;

namespace CabinetVeterinarPS.Presenter
{
    class PrezentareMedic
    {
        IVizualizareGestionareProgram viz;
        PersistentaMedic persistenta;

        public PrezentareMedic(IVizualizareGestionareProgram viz)
        {
            this.viz = viz;
            this.persistenta = new PersistentaMedic();
        }


        public void Lista()
        {
            List<string[]> listaMedici = new List<string[]>();
            foreach (Medic u in this.persistenta.GetListaMedici())
            {
                listaMedici.Add(u.ConversieMed());
            }
            this.viz.ListaMedici = listaMedici;
        }
        public void Cautare()
        {
            List<string[]> listaMedici = new List<string[]>();
            foreach (Medic u in this.persistenta.GetListaMedici())
            {
                //if (this.viz.Id == u.Id)
                //{
                    listaMedici.Add(u.ConversieMed());
                //}
            }
            this.viz.ListaMedici = listaMedici;
        }

        public bool ActualizareMedic()
        {
            if (this.viz.Selectie != null)
            {

                var confirmare = MessageBox.Show("Doriti intr-adevar actualizarea utilizatorului selectat?",
                    "ACTUALIZARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                /*if(this.viz.LuniOraStart <7 && this.viz.LuniOraSop<this.viz.LuniOraStart && this.viz.LuniOraSop>24)
                {
                    MessageBox.Show("EROARE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }*/

                ProgramZi luni = new ProgramZi(this.viz.LuniOraStart, this.viz.LuniOraSop);
                ProgramZi marti = new ProgramZi(this.viz.MartiOraStart, this.viz.MartiOraSop);
                ProgramZi miercuri = new ProgramZi(this.viz.MiercuriOraStart, this.viz.MiercuriOraSop);
                ProgramZi joi = new ProgramZi(this.viz.JoiOraStart, this.viz.JoiOraSop);
                ProgramZi vineri = new ProgramZi(this.viz.VineriOraStart, this.viz.VineriOraSop);
                int index = 1;
                Medic medic = new Medic(index, luni, marti, miercuri, joi, vineri);
                    index++;

                if (confirmare == DialogResult.Yes)
                {
                    //bool succes = this.persistenta.ActualizareMedic(this.viz.Selectie, medic);
                    bool succes = this.persistenta.ActualizareMedic(this.viz.Selectie, medic);

                    if (!succes)
                        MessageBox.Show("EROARE LA actualizare", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return succes;
                    
                }
                else
                    return false;
            }
            else
            {
                MessageBox.Show("Nu s-a selectat niciun utilizator", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
