using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tema2PS.Model.Persistenta
{
    class PersistentaUtilizator
    {
        string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
        private List<Utilizator> utilizatori;

        public PersistentaUtilizator()
        {
            this.utilizatori = new List<Utilizator>();
            this.citireDB();
        }

        public void citireDB()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("UtilizatorViewAll", mysqlCon))
                {
                    using(var reader = mysqlCmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            var id = Convert.ToInt32(reader.GetString(0));
                            var rol = reader.GetString(1);
                            var email = reader.GetString(2);
                            var parola = reader.GetString(3);
                            Utilizator u = new Utilizator(id, rol, email, parola);
                            utilizatori.Add(u);
                        }
                    }

                }
            }
        }
        public string Logare(string numeUtilizator, string parola)
        {
            for (int i = 0; i < utilizatori.Count; i++)
            {
                if (utilizatori[i].Email == numeUtilizator && utilizatori[i].Parola == parola)
                    return utilizatori[i].Rol;
            }
            return null;
        }
        public List<Utilizator> ListaUtilizatori()
        {
            List<Utilizator> listUtil = new List<Utilizator>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("UtilizatorViewAll", mysqlCon))
                {
                    using (var reader = mysqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = Convert.ToInt32(reader.GetString(0));
                            var rol = reader.GetString(1);
                            var email = reader.GetString(2);
                            var parola = reader.GetString(3);
                            Utilizator u = new Utilizator(id, rol, email, parola);
                            listUtil.Add(u);
                        }
                    }
                }
            }
            return listUtil;
        }

        public void AdaugareUtilizator(Utilizator utilizator)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("UtilizatorAddSauEdit", mysqlCon))
                {
                    mysqlCmd.CommandType = CommandType.StoredProcedure;
                    mysqlCmd.Parameters.AddWithValue("_IDUtilizator", utilizator.Id);
                    mysqlCmd.Parameters.AddWithValue("_RolUtilizator", utilizator.Rol);
                    mysqlCmd.Parameters.AddWithValue("_EmailUtilizator", utilizator.Email);
                    mysqlCmd.Parameters.AddWithValue("_ParolaUtilizator", utilizator.Parola);
                    mysqlCmd.Parameters.AddWithValue("_OraStart", 0);
                    mysqlCmd.Parameters.AddWithValue("_OraStop", 0);
                    mysqlCmd.ExecuteNonQuery();
                }
            }
        }

        public void StergereUtilizator(Utilizator utilizator)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("UtilizatorDeleteByID", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_IDUtilizator", utilizator.Id);
                mysqlCmd.ExecuteNonQuery();
            }
        }

        public void CautareUtilizator(string roll)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("UtilizatorSearchByRol", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_RolUtilizator", roll);
                DataTable dtbUtilizator = new DataTable();
                sqlDa.Fill(dtbUtilizator);
            }
        }
    }
}
