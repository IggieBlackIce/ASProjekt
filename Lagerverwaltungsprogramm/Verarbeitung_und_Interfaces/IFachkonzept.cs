using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verarbeitung_und_Interfaces
{
    interface IFachkonzept
    {
        int GetRegalNr(Regal einRegal);
        SetRegalNr(Regal einRegal, int nr);


        List<Regal> GetAlleRegale();
        bool SchreibeRegal(Regal einRegal);
        bool LöscheRegal(Regal einRegal);
        bool AktualisiereRegal(Regal einRegal);

        Produkt LeseProdukt(int produktID);
        List<Produkt> LeseAlleProdukte();
        List<Produkt> LeseAlleProdukteInRegal(int regalNr);
        bool SchreibeProdukt(Produkt einProdukt);
        bool LöscheProdukt(Produkt einProdukt);
        bool AktualisiereProdukt(Produkt einProdukt);
    }
}
