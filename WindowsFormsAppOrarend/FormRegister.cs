using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    public partial class FormRegister : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxjelszo.Text == textBoxjelszo.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orarend.tanarok WHERE tanarnev='" + textBoxnev.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Már létezik felhasználónév, próbálkozzon másikkal ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orarend.tanarok VALUES(@tanarnev,@jelszo)", cn);
                    cmd.Parameters.AddWithValue("tanarnev", textBoxnev.Text);
                    cmd.Parameters.AddWithValue("jelszo", textBoxjelszo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hozzon létre egy profilr. Kérem, lépje be.", "Kész", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kérem, írja be a jelszó ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*if (Program.db.validUser(textBoxnev.Text, textBoxjelszo.Text) >= 0)
            {
                this.Hide();
                FormRegister registration = new FormRegister();
                registration.ShowDialog();
                Program.formTanarok.Show();
            }*/
        }
    }
}
