using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppProjekt
{
    internal class Kund 
    {
        public int id { get; set; }
        public string namn { get; set; }
        public string telefonnummer { get; set; }
        public string adress { get; set; }
        public string losenord { get; set; }

        //Lista för personal 
        public static List<Kund> kund = new List<Kund>();

        public Kund(int id, string namn, string telefonnummer, string adress, string losenord)
        {
            this.id = id;
            this.namn = namn;
            this.telefonnummer = telefonnummer;
            this.adress = adress;
            this.losenord = losenord;
        }
    }
}
