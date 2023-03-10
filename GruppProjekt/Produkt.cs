using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppProjekt
{
    internal class Produkt
    {
        public int produktid { get; set; }
        public string produktnamn { get; set; }
        public string produktmarke { get; set; }
        public decimal pris { get; set; }
        public string matvarugrupp { get; set; }
        public int antal { get; set; }


        //Lista för produkter
        public static List<Produkt> produkt = new List<Produkt>();

        public Produkt(int produktid, string produktnamn, string produktmarke, decimal pris, string matvarugrupp, int antal)
        {
            this.produktid = produktid;
            this.produktnamn = produktnamn;
            this.produktmarke= produktmarke;
            this.pris = pris;
            this.matvarugrupp = matvarugrupp;
            this.antal = antal;
        }
    }
}
