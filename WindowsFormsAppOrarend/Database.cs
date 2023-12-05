using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;

        public Database() 
        {
            MySqlBaseConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orarend";
            connection = new MySqlConnection();
            command = connection.CreateCommand();
            try
            {
                nyit();

                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void nyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public List<Modifycation> getModiy()
        {
            nyit();
            List<Modifycation> modositas = new List<Modifycation>();
            command.CommandText = "SELECT `oraid`,`tantargy`,`sorszam`,`hetnap` FROM `orak` WHERE 1 ORDER BY tanarnev";
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while(dr.Read())
                {
                    modositas.Add(new Modifycation(dr.GetInt32("oraid"), dr.GetString("tantargy"), dr.GetInt32("sorszam"), dr.GetInt32("hetnap")));
                }
            }
            zar();
            return modositas;
        }
        public int validUser(string username, string password)
        {
            int result = 0;
            command.CommandText = "SELECT tanarok.jelszo, tanatok.tanarid FROM tanarok WHERE tanarok.tanarnev=@tanarnev";
        }
    }
}
