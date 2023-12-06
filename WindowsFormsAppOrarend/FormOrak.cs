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
    public partial class FormOrak : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public FormOrak()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModositasok formTermekUj = new FormModositasok("beszúrás");
            formTermekUj.ShowDialog(); // model
        }

        private void modósításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModositasok formUpdate = new FormModositasok("módosítás");
            formUpdate.ShowDialog();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModositasok formDelete = new FormModositasok("törlés");
            formDelete.ShowDialog();
        }

        //INSERT INTO `orak` (`oraid`, `tantargy`, `sorszam`, `hetnapja`) VALUES(NULL, 'Ének', '1', 'szerda'), (NULL, 'Irodalom és Nyelvtan', '2', 'szerda'), (NULL, 'Történelem', '3', 'szerda'), (NULL, 'Informatik', '4', 'szerda'), (NULL, 'Ének', '5', 'szerda'), (NULL, 'Testnevelés', '6', 'szerda'), (NULL, 'Történelem', '1', 'csütörtök'), (NULL, 'Mozgókép ismeret', '2', 'csütörtök'), (NULL, 'Informatika', '3', 'csütörtök'), (NULL, 'Ének', '4', 'csütörtök'), (NULL, 'Matek', '5', 'csütörtök'), (NULL, 'Testnevelés', '6', 'csütörtök'), (NULL, 'Biológia', '1', 'péntek'), (NULL, 'Biológia', '2', 'péntek'), (NULL, 'Kémia', '3', 'péntek'), (NULL, 'Kémia', '4', 'péntek'), (NULL, 'Testnevelés', '5', 'péntek'), (NULL, 'Ének', '6', 'péntek');
        //INSERT INTO `orak` (`oraid`, `tantargy`, `sorszam`, `hetnapja`) VALUES(NULL, 'Matek', '1', 'hétfő'), (NULL, 'Magyar', '2', 'hétfő'), (NULL, 'Tesnevelés', '3', 'hétfő'), (NULL, 'Irodalom és Nyelvtan', '4', 'hétfő'), (NULL, 'Informatika', '5', 'hétfő'), (NULL, 'Ének', '6', 'hétfő'), (NULL, 'Matek', '1', 'kedd'), (NULL, 'Irodalom és nyelvtan', '2', 'kedd'), (NULL, 'Történelem', '3', 'kedd'), (NULL, 'Informatika', '4', 'kedd'), (NULL, 'Tesnevelés', '5', 'kedd'), (NULL, 'Életvitel és Kiltúra', '6', 'kedd');

        private void listBoxTanarok_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listBoxTanarok.SelectedIndex < 0)
            {
                return;
            }
            Ora kivalasztottTanarok = (Ora)listBoxTanarok.SelectedItem;
            textBoxOra.Text = kivalasztottTanarok.oraid.ToString();
            comboBoxTantargy.Text = kivalasztottTanarok.tantargy; // listboxba át alakítás
            numericUpDownSorszam.Value = kivalasztottTanarok.sorszam; // listboxba át alakítás
            numericUpDownSorszam.Maximum = kivalasztottTanarok.sorszam; // listboxba át alakítás
            numericUpDownSorszam.Value = -1;
            comboBoxHetnap.Text = kivalasztottTanarok.hetnapja; // listboxba át alakítás */
            textBoxOra_TextChanged();
            numericUpDownSorszam_ValueChanged();
            comboBoxTantargy_SelectedIndexChanged();
            comboBoxHetnap_SelectedIndexChanged();

        }

        private void buttonIgenyles_Click(object sender, EventArgs e)
        {
            string text = $"Szeretné-e a kíválasztani azt a tanárt akihez az adott napon szeretne menni: ${comboBoxTantargy}, ${numericUpDownSorszam}, ${comboBoxHetnap}?";
        }

        private void textBoxOra_TextChanged(object sender, EventArgs e)
        {
            // A textBoxOra text az id. Itt lehet meg tudni az adot tantárgyokat és majd hozzá adja a textBoxTanarok részbe.
            if (textBoxOra.Text == textBoxOra.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orak.oraid WHERE oraid='" + textBoxOra.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();                    
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orak.oraid VALUES(@oraid)", cn);
                    cmd.Parameters.AddWithValue("oraid", textBoxOra.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (listBoxTanarok.SelectedIndex < 0)
                {
                    return;
                }
                Ora kivalasztottTanarok = (Ora)listBoxTanarok.SelectedItem;
                textBoxOra.Text = kivalasztottTanarok.oraid.ToString();
                MessageBox.Show("Kérem, írja be a jelszó ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void numericUpDownSorszam_ValueChanged(object sender, EventArgs e)
        {
            // Hozzá adja a textboxTanarok-ba és így megjelenik az amire választott
            if (comboBoxTantargy.Text == comboBoxTantargy.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orak.tantargy WHERE tantargy='" + comboBoxTantargy.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orak.tantargy VALUES(@tantargy)", cn);
                    cmd.Parameters.AddWithValue("tantargyak", comboBoxTantargy.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (listBoxTanarok.SelectedIndex < 0)
                {
                    return;
                }
                Ora kivalasztottTanarok = (Ora)listBoxTanarok.SelectedItem;
                comboBoxTantargy.Text = kivalasztottTanarok.tantargy; // listboxba át alakítás
            }
        }

        private void comboBoxTantargy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hozzá adja a textboxTanarok-ba és így megjelenik az amire választott
            if (numericUpDownSorszam.Text == numericUpDownSorszam.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orak.sorszam WHERE sorszam='" + numericUpDownSorszam.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orak.sorszam VALUES(@sorszam)", cn);
                    cmd.Parameters.AddWithValue("sorszam", numericUpDownSorszam.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (listBoxTanarok.SelectedIndex < 0)
                {
                    return;
                }
                Ora kivalasztottTanarok = (Ora)listBoxTanarok.SelectedItem;
                numericUpDownSorszam.Value = kivalasztottTanarok.sorszam;
            }
        }

        private void comboBoxHetnap_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hozzá adja a textboxTanarok-ba és így megjelenik az amire választott
            if (comboBoxHetnap.Text == comboBoxHetnap.Text)
            {
                cmd = new SqlCommand("SELECT * FROM orak.hetnapja WHERE hetnapja='" + comboBoxHetnap.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT orak.hetnapja VALUES(@hetnapja)", cn);
                    cmd.Parameters.AddWithValue("hetnapja", comboBoxHetnap.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                if (listBoxTanarok.SelectedIndex < 0)
                {
                    return;
                }
                Ora kivalasztottTanarok = (Ora)listBoxTanarok.SelectedItem;
                comboBoxHetnap.Text = kivalasztottTanarok.hetnapja;
            }
        }
    }
}
