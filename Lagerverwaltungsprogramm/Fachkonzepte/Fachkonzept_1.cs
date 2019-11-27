Fachkonzept_1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUndBesitzer.Fachkonzept
{
    class Fachkonzept_1
    {
        protected List<Auto> ausgabeAufsteigend(List<Produkt> liste) {
            List<Auto> SortedList = liste.OrderBy(a=>a.Produktname).ToList();
            return SortedList;
        }
    }
}