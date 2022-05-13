using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tema2PS.Model.Persistenta
{
    class PersistentaFisaMed
    {
        string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
        private List<FisaMedicala> fiseMedicale;

        public PersistentaFisaMed()
        {
            this.fiseMedicale = new List<FisaMedicala>();
            this.citireDB();
        }

        public void citireDB()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("FiseViewAll", mysqlCon))
                {
                    using (var reader = mysqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var nrcrt = Convert.ToInt32(reader.GetString(0));
                            var cip = Convert.ToInt32(reader.GetString(1));
                            var specie = reader.GetString(2);
                            var medic = Convert.ToInt32(reader.GetString(3));
                            var ziua = reader.GetString(4);
                            var ora = Convert.ToInt32(reader.GetString(5));
                            var simptom = reader.GetString(6);
                            var diagnostic = reader.GetString(7);
                            var tratament = reader.GetString(8);
                            FisaMedicala u = new FisaMedicala(nrcrt, cip, specie, medic, ziua, ora, simptom, diagnostic, tratament);
                            fiseMedicale.Add(u);
                        }
                    }

                }
            }
        }

        public List<FisaMedicala> LisaFise()
        {
            List<FisaMedicala> listUtil = new List<FisaMedicala>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("FiseViewAll", mysqlCon))
                {
                    using (var reader = mysqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var nrcrt = Convert.ToInt32(reader.GetString(0));
                            var cip = Convert.ToInt32(reader.GetString(1));
                            var specie = reader.GetString(2);
                            var medic = Convert.ToInt32(reader.GetString(3));
                            var ziua = reader.GetString(4);
                            var ora = Convert.ToInt32(reader.GetString(5));
                            var simptom = reader.GetString(6);
                            var diagnostic = reader.GetString(7);
                            var tratament = reader.GetString(8);
                            FisaMedicala u = new FisaMedicala(nrcrt, cip, specie, medic, ziua, ora, simptom, diagnostic, tratament);
                            listUtil.Add(u);
                            //Console.WriteLine(u.NrCrt + " " + u.Cip + u.Specie + u.Medic + u.Ziua + u.Ora + u.Simptome + u.Diagnostic + u.Tratament);
                        }
                    }
                }
            }
            return listUtil;
        }

        public void AdaugareFisa(FisaMedicala fisaMedicala)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("FiseAddSauEdit", mysqlCon))
                {
                    mysqlCmd.CommandType = CommandType.StoredProcedure;
                    mysqlCmd.Parameters.AddWithValue("_NRCRT", fisaMedicala.NrCrt);
                    mysqlCmd.Parameters.AddWithValue("_CipAnimal", fisaMedicala.Cip);
                    mysqlCmd.Parameters.AddWithValue("_SpecieAnimal", fisaMedicala.Specie);
                    mysqlCmd.Parameters.AddWithValue("_MedicFisa", fisaMedicala.Medic);
                    mysqlCmd.Parameters.AddWithValue("_ZiuaFisa", fisaMedicala.Ziua);
                    mysqlCmd.Parameters.AddWithValue("_OraFisa", fisaMedicala.Ora);
                    mysqlCmd.Parameters.AddWithValue("_Simptome", fisaMedicala.Simptome);
                    mysqlCmd.Parameters.AddWithValue("_Diagnostic", fisaMedicala.Diagnostic);
                    mysqlCmd.Parameters.AddWithValue("_Tratament", fisaMedicala.Tratament);
                    mysqlCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
