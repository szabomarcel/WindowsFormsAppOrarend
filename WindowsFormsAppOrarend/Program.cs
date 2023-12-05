using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    internal static class Program
    {
        //-- a többi osztályban (Form-ok) is használható
        public static FormOrak formOrak = null;
        public static FormModositasok formModositasok = null;
        public static FormRegister formRegister = null;
        public static FormTanarok formTanarok = null;
        public static int UserId;
        public static Database db = new Database();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formOrak = new FormOrak();
            formModositasok = new FormModositasok();
            formRegister = new FormRegister();
            formTanarok = new FormTanarok();
            Application.Run(formOrak);
        }
    }
}
