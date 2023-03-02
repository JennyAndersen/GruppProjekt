using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppProjekt
{
    internal class Personal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string telefonnummer { get; set; }
        public string adress { get; set; }
        public string losenord { get; set; }

        public Personal(int id, string name, string telefonnummer, string adress, string losenord)
        {
            this.id = id;
            this.name = name;
            this.telefonnummer = telefonnummer;
            this.adress = adress;
            this.losenord = losenord;
        }
    }
}
