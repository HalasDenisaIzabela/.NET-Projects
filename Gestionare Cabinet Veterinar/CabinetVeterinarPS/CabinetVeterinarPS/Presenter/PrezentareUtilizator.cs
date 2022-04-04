using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetVeterinarPS.Model;
using CabinetVeterinarPS.Model.Persistenta;
using CabinetVeterinarPS.View;
using CabinetVeterinarPS.View.Admin;

namespace CabinetVeterinarPS.Presenter
{
    class PrezentareUtilizator
    {
        IVizualizareAdmin viz;
        PersistentaUtilizator persistenta;
        PersistentaMedic persistentaMed;

        public PrezentareUtilizator(IVizualizareAdmin viz)
        {
            this.viz = viz;
            this.persistenta = new PersistentaUtilizator();
            this.persistentaMed = new PersistentaMedic();

        }


        public void Lista()
        {
            List<string[]> listaUtilizatori = new List<string[]>();
            foreach (Utilizator u in this.persistenta.GetListaUtilizatori())
            {
                listaUtilizatori.Add(u.Conversie());
            }
            this.viz.ListaUtilizatori = listaUtilizatori;
        }
        public void Cautare()
        {
            List<string[]> listaUtilizatori = new List<string[]>();
            foreach (Utilizator u in this.persistenta.GetListaUtilizatori())
            {
                if (this.viz.Rol == u.Rol)
                {
                    listaUtilizatori.Add(u.Conversie());
                }
            }
            this.viz.ListaUtilizatori = listaUtilizatori; 
        }

        public bool Adaugare()
        {
            if (this.viz.Rol == "")
            {
                MessageBox.Show("Trebuie sa introduceti si rolul!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viz.Email == "")
            {
                MessageBox.Show("Trebuie sa introduceti si emailul!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.viz.Parola == "")
            {
                MessageBox.Show("Trebuie sa introduceti si parola!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int index = 0;
            if(this.viz.Rol == "dr")
            {
                if (this.viz.Id.ToString() == "")
                {
                    MessageBox.Show("Trebuie sa introduceti si Id-ul!!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (this.viz.Id.ToString() != "" && this.viz.Email != "" && this.viz.Parola != "")
                {
                    if (this.viz.Id != 0)
                    {
                        Medic medic = new Medic(this.viz.Id, this.viz.Rol, this.viz.Email, this.viz.Parola);
                        bool succes2 = this.persistentaMed.AdaugareMedic(medic);
                        Utilizator utilizator = new Utilizator(this.viz.Rol, this.viz.Email, this.viz.Parola);
                        bool succes = this.persistenta.AdaugareUtilizator(utilizator);
                        return succes2;
                    }
                    else return false;
                    
                }
                else return false;
            }
            else if (this.viz.Rol != "" && this.viz.Email != "" && this.viz.Parola != "")
            {
             
                    Utilizator utilizator = new Utilizator(this.viz.Rol, this.viz.Email, this.viz.Parola);
                    bool succes = this.persistenta.AdaugareUtilizator(utilizator);
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
                var confirmare = MessageBox.Show("Doriti intr-adevar stergerea patinatorului selectat?",
                    "STERGERE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmare == DialogResult.Yes)
                {
                    if(this.viz.Rol == "dr")
                    {
                        bool succes2 = this.persistentaMed.StergereMedic(this.viz.Selectie);
                    }
                    bool succes = this.persistenta.StergereUtilizator(this.viz.Selectie);
                    if (!succes)
                        MessageBox.Show("EROARE LA STERGERE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool Actualizare()
        {
            if (this.viz.Selectie != null)
            {

                var confirmare = MessageBox.Show("Doriti intr-adevar actualizarea utilizatorului selectat?",
                    "ACTUALIZARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                this.viz.Rol = "";
                Utilizator utilizator = new Utilizator(this.viz.Rol, this.viz.Email, this.viz.Parola);
                
                    if (confirmare == DialogResult.Yes)
                    {
                        bool succes = this.persistenta.ActualizareUtilizator(this.viz.Selectie, utilizator);
                        if (!succes)
                            MessageBox.Show("EROARE LA STERGERE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
