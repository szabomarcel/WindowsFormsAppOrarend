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
    public partial class FormModositasok : Form
    {
        string modify = null;
        Ora kivalasztasModify = null;
        public FormModositasok(string modify)
        {
            InitializeComponent();
            this.modify = modify;
        }

        private void FormModositasok_Load(object sender, EventArgs e)
        {
            switch (modify)
            {
                case "beszúrás":
                    this.Text = "Új óra, sorszám, tantárgy hozzásadás";
                    adatLetrehozzas();
                    break;
                case "módosítás":
                    this.Text = "Óra, sorszám, tantárgy modósítása";
                    adatLetrehozzas();
                    break;
                case "törlés":
                    this.Text = "óra, sorszám, tantárgy törlés";
                    adatLetrehozzas();
                    break;
                default:
                    break;
            }
        }

        private void adatLetrehozzas()
        {
            textBoxOraId.Text = kivalasztasModify.oraid.ToString();
            textBoxTantargyak.Text = kivalasztasModify.tantargy.ToString();
            numericUpDownSorszam.Value = kivalasztasModify.sorszam;
            comboBoxNapja.Text = kivalasztasModify.hetnapja.ToString();
        }
    }
}
