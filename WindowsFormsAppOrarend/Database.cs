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
        public List<Ora> getModify()
        {
            nyit();
            List<Ora> modositas = new List<Ora>();
            command.CommandText = "SELECT `oraid`,`tantargy`,`sorszam`,`hetnap` FROM `orak` WHERE 1 ORDER BY tanarnev";
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while(dr.Read())
                {
                    modositas.Add(new Ora(dr.GetInt32("oraid"), dr.GetString("tantargy"), dr.GetInt32("sorszam"), dr.GetString("hetnap")));
                }
            }
            zar();
            return modositas;
        }
        public int validUser(string username, string password)
        {
            int userid = -1;
            command.CommandText = "SELECT tanarok.jelszo, tanatok.tanarid FROM tanarok WHERE tanarok.tanarnev=@tanarnev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", textBox_nev.Text);
            MySqlDataReader reader = Program.command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                Program.UserId = reader.GetInt32("vasarlo");
            }
            zar();
            return userid;
        }
    }
}
