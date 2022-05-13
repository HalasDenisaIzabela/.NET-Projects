using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tema2PS.Model.Persistenta
{
    class ParsistentaMedic
    {
        string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
        private List<Medic> medici;

        public ParsistentaMedic()
        {
            this.medici = new List<Medic>();
            this.citireDB();
        }

        public void citireDB()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("UtilizatorViewAllDr", mysqlCon))
                {
                    using (var reader = mysqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = Convert.ToInt32(reader.GetString(0));
                            var rol = reader.GetString(1);
                            var email = reader.GetString(2);
                            var parola = reader.GetString(3);
                            var oraStar = Convert.ToInt32(reader.GetString(4));
                            var oraSto = Convert.ToInt32(reader.GetString(5));
                            Medic u = new Medic(id, rol, email, parola, oraStar, oraSto);
                            medici.Add(u);
                        }
                    }

                }
            }
        }

        public List<Medic> ListaMedici()
        {
            List<Medic> listMed = new List<Medic>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("UtilizatorViewAllDr", mysqlCon))
                {
                    using (var reader = mysqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = Convert.ToInt32(reader.GetString(0));
                            var rol = reader.GetString(1);
                            var email = reader.GetString(2);
                            var parola = reader.GetString(3);
                            var oraStar = Convert.ToInt32(reader.GetString(4));
                            var oraSto = Convert.ToInt32(reader.GetString(5));
                            Medic u = new Medic(id, rol, email, parola, oraStar, oraSto);
                            listMed.Add(u);
                        }
                    }
                }
            }
            return listMed;
        }

        public void ActualizareMedic(Medic medic)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("UtilizatorAddSauEdit", mysqlCon))
                {
                    mysqlCmd.CommandType = CommandType.StoredProcedure;
                    mysqlCmd.Parameters.AddWithValue("_IDUtilizator", medic.Id);
                    mysqlCmd.Parameters.AddWithValue("_RolUtilizator", medic.Rol);
                    mysqlCmd.Parameters.AddWithValue("_EmailUtilizator", medic.Email);
                    mysqlCmd.Parameters.AddWithValue("_ParolaUtilizator", medic.Parola);
                    mysqlCmd.Parameters.AddWithValue("_OraStart", medic.oraStart);
                    mysqlCmd.Parameters.AddWithValue("_OraStop", medic.oraStop);
                    mysqlCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
