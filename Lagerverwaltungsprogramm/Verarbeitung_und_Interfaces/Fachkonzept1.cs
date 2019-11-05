using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verarbeitung_und_Interfaces
{
    public class Fachkonzept1 : IFachkonzept
    {
        public bool AktualisiereProdukt(Produkt einProdukt)
        {
            throw new NotImplementedException();
        }

        public bool AktualisiereRegal(Regal einRegal)
        {
            throw new NotImplementedException();
        }

        public List<Regal> GetAlleRegale()
        {
            throw new NotImplementedException();
        }

        public int GetRegalNr(Regal einRegal)
        {
            throw new NotImplementedException();
        }

        public List<Produkt> LeseAlleProdukte()
        {
            throw new NotImplementedException();
        }

        public List<Produkt> LeseAlleProdukteInRegal(int regalNr)
        {
            throw new NotImplementedException();
        }

        public Produkt LeseProdukt(int produktID)
        {
            throw new NotImplementedException();
        }

        public bool LöscheProdukt(Produkt einProdukt)
        {
            throw new NotImplementedException();
        }

        public bool LöscheRegal(Regal einRegal)
        {
            throw new NotImplementedException();
        }

        public bool SchreibeProdukt(Produkt einProdukt)
        {
            throw new NotImplementedException();
        }

        public bool SchreibeRegal(Regal einRegal)
        {
            throw new NotImplementedException();
        }

        public void SetRegalNr(Regal einRegal, int nr)
        {
            throw new NotImplementedException();
        }
    }
}
