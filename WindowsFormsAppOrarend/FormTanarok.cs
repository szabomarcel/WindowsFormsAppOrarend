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
    public partial class FormTanarok : Form
    {
        public FormTanarok()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (Program.db.validUser(textBoxnev.Text, textBoxjelszo.Text) >= 0)
            {
                Program.formRegister.Show();
            }
        }

        private void button_belep_Click(object sender, EventArgs e)
        {
            if (Program.db.validUser(textBoxnev.Text, textBoxjelszo.Text) >= 0)
            {
                Program.formOrak.Show();
            }
        }
    }
}
