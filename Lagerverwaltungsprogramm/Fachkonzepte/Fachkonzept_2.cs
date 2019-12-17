Fachkonzept_2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUndBesitzer.Fachkonzept
{
    class Fachkonzept_2
    {
        protected List<Auto> ausgabeAbsteigend(List<Produkt> liste) {
            List<Auto> SortedList = liste.OrderByDescending(a=>a.Produktname).ToList();
            return SortedList;
        }
    }
}
