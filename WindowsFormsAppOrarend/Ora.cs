using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppOrarend
{
    internal class Ora
    {
        public int oraid;
        public string tantargy;
        public int sorszam;
        public string hetnapja;

        public Ora(int oraid, string tantargy, int sorszam, string hetnapja)
        {
            this.oraid = oraid;
            this.tantargy = tantargy;
            this.sorszam = sorszam;
            this.hetnapja = hetnapja;
        }
        public override string ToString()
        {
            return $"{tantargy}";
        }
    }
}
