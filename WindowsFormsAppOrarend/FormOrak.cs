using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    public partial class FormOrak : Form
    {
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

        private void listBoxTanarok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTanarok.SelectedIndex < 0)
            {
                return;
            }
            Ora kivalasztottTanarok = (Ora)listBoxTanarok.SelectedItem;
            textBoxOra.Text = kivalasztottTanarok.oraid.ToString();
            textBoxTantargy.Text = kivalasztottTanarok.tantargy; // listboxba át alakítás
            numericUpDownSorszam.Value = kivalasztottTanarok.sorszam; // listboxba át alakítás
            numericUpDownSorszam.Maximum = kivalasztottTanarok.sorszam; // listboxba át alakítás
            numericUpDownSorszam.Value = -1;
            comboBoxHetnap.Text = kivalasztottTanarok.hetnapja; // listboxba át alakítás 
        }

        private void buttonIgenyles_Click(object sender, EventArgs e)
        {
            string text = $"Szeretné-e a kíválasztani azt a tanárt akihez az adott napon szeretne menni: ${textBoxTantargy}, ${numericUpDownSorszam}, ${comboBoxHetnap}?";
        }
    }
}
