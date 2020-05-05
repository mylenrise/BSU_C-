using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Guide
{
    class QueryStatements
    {
        MySqlConnection conn;
        public QueryStatements()
        {
            conn = Connector.GetDBConnection();
        }


        public void Insert(Shoe shoe)
        {
            int lastId = 0;
            using (StreamReader sr = new StreamReader("shoes_data.txt"))
            {
                string line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                }
                lastId = Convert.ToInt32(line.Split(' ')[0]);
                ++lastId;
            }
            conn.Open();
            String query = "INSERT INTO shoe VALUES ('" + lastId.ToString() + "', " + shoe.ToString();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            using (StreamWriter w = new StreamWriter("shoes_data.txt", true, Encoding.GetEncoding(1251)))
            {
                w.Write('\n' + lastId.ToString() + " " + shoe.GetRawString());

            }
            

        }

        public void Delete(int index)
        {
            string id = "";
            List<string> tmpData = new List<string>();
            // string tmpData = "";
            using (StreamReader sr = new StreamReader("shoes_data.txt"))
            {
                string line = "";
                int count = 0;
                bool isCorrect = false;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (index == count)
                    {
                        id = line.Split(' ')[0];
                        isCorrect = true;
                    }
                    else
                    {
                        tmpData.Add(line);

                    }


                    count++;
                }
                if (!isCorrect)
                {
                    return;
                }


            }
            conn.Open();
            string query = "DELETE FROM shoe WHERE id='" + id + "'";


            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            using (StreamWriter w = new StreamWriter("shoes_data.txt", false, Encoding.GetEncoding(1251)))
            {
                foreach (string t in tmpData)
                    w.WriteLine(t);

            }

        }

        public List<string>[] Select()
        {
            string query = "SELECT * FROM shoe";

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                list[0].Add(dataReader["id"] + "");
                list[1].Add(dataReader["name"] + "");
                list[2].Add(dataReader["type_id"] + "");
                list[3].Add(dataReader["price"] + "");
                list[4].Add(dataReader["amount"] + "");
            }

            dataReader.Close();
            conn.Close();
            return list;

        }
    }
}
