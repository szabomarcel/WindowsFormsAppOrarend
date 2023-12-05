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
    }
}
