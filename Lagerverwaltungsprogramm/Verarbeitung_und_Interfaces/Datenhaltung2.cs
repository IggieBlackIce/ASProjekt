using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Verarbeitung_und_Interfaces
{
    class Datenhaltung2 : IDatenhaltung
    {
        public int readjson()
        {

            string json = File.ReadAllText("Datenbank.json");
            Datenhaltung2 datenhaltung2 = JsonConvert.DeserializeObject<Datenhaltung2>(json);
            return 0;
        }
        public bool AktualisiereProdukt(Produkt einProdukt)
        {
            throw new NotImplementedException();
        }

        public bool AktualisiereRegal(Regal einRegal)
        {
            throw new NotImplementedException();
        }

        public bool ErstelleOderLadeSpeichermedium()
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

        public List<Regal> LeseAlleRegale()
        {
            throw new NotImplementedException();
        }

        public Produkt LeseProdukt(int produktID)
        {
            throw new NotImplementedException();
        }

        public Regal LeseRegal(int regalNr)
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
    }
}
