using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuizApp
{
    internal class BDDQuestion
    {

        private MySqlConnection connection;

        
        private void connect()
        {
            string server = "127.0.0.1";
            string database = "quizapp";
            string username = "root";
            string password = "";
            //string port = "";
            //string sslM = "none";

            string connString = $"server={server}; database={database}; user id={username}; password={password};";

            this.connection = new MySqlConnection(connString);

            try
            {
                this.connection.Open();

                Console.WriteLine("Connection Successful");
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message + connString);
            }

        }

        public List<string> getBDD (int Id)
        {
            connect();

            List<string> list = new List<string>();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM quizapp WHERE Id={Id}", this.connection);

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                //list.Add(reader.GetString("id").ToString());
                list.Add(reader.GetString("Label").ToString());
                list.Add(reader.GetString("Answer1").ToString());
                list.Add(reader.GetString("Answer2").ToString());
                list.Add(reader.GetString("Answer3").ToString());
                list.Add(reader.GetString("Answer4").ToString());
                list.Add(reader.GetString("IAnswer").ToString());
            }

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            this.connection.Close();

            return list;
        }

    }
}
