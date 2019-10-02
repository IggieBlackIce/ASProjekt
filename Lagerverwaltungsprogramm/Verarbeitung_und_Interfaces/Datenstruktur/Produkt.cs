using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verarbeitung_und_Interfaces
{
    public class Produkt
    {
        int ProduktID { get; set; }
        string ProduktName { get; set; }
        int RegalNr { get; set; }

        Produkt(int produktID, string produktName, int regalNr)
        {
            ProduktID = produktID;
            ProduktName = produktName;
            RegalNr = regalNr;
        }

        Produkt(string produktName, int regalNr)
        {
            ProduktName = produktName;
            RegalNr = regalNr;
        }

        Produkt() { }
    }
}
