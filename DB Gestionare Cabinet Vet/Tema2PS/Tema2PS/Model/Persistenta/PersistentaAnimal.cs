using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CsvHelper;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Tema2PS.Model.Persistenta
{
    class PersistentaAnimal
    {

        string connectionString = @"Server=localhost;Database=cabinetvet;Uid=root;Pwd=root";
        private List<Animal> animale;

        public PersistentaAnimal()
        {
            this.animale = new List<Animal>();
            this.citireDB();
        }

        public void citireDB()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("AnimaleViewAll", mysqlCon))
                {
                    using (var reader = mysqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cip = Convert.ToInt32(reader.GetString(0));
                            var specie = reader.GetString(1);
                            Animal u = new Animal(cip, specie);
                            animale.Add(u);
                        }
                    }

                }
            }
        }

        internal void ScriereCSV()
        {
            List<Animal> list = ListaAnimale();
            using (var writer = new StreamWriter("Raport.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(list);
            }
        }

        public void ScriereJSON()
        {
            List<Animal> list = ListaAnimale();
            string strResultJson = JsonConvert.SerializeObject(list);
            File.WriteAllText(@"animale.json", strResultJson);
        }

        public void ScriereXML()
        {
            List<Animal> list = ListaAnimale();

            XmlSerializer serialiser = new XmlSerializer(typeof(List<Animal>));

            TextWriter Filestream = new StreamWriter(@"AnimaleXML-" + ".xml");

            serialiser.Serialize(Filestream, list);

            Filestream.Close();
        }

        public List<Animal> ListaAnimale()
        {
            List<Animal> listAnim = new List<Animal>();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("AnimaleViewAll", mysqlCon))
                {
                    using (var reader = mysqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cip = Convert.ToInt32(reader.GetString(0));
                            var specie = reader.GetString(1);
                            Animal u = new Animal(cip, specie);
                            listAnim.Add(u);
                        }
                    }
                }
            }
            return listAnim;
        }

        public void AdaugareAnimal(Animal animal)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                using (MySqlCommand mysqlCmd = new MySqlCommand("AnimaleAddSauEdit", mysqlCon))
                {
                    mysqlCmd.CommandType = CommandType.StoredProcedure;
                    mysqlCmd.Parameters.AddWithValue("_CIP", animal.Cip);
                    mysqlCmd.Parameters.AddWithValue("_Specie", animal.Specie);
                    mysqlCmd.ExecuteNonQuery();
                }
            }
        }

        public void StergereAnimal(Animal animal)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("AnimaleDeleteByCIP", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;
                mysqlCmd.Parameters.AddWithValue("_CIP", animal.Cip);
                mysqlCmd.ExecuteNonQuery();
            }
        }
    }
}
