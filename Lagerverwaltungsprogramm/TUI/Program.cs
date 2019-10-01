using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUI
{
    class Program
    {
        static void Main(string[] args)
        {
            printoptions();
            getinput();

            Console.ReadLine();
        }

        public static void printoptions()
        {
            Console.WriteLine("");
            Console.WriteLine("LAGERVERWALTUNGSPROGRAMM");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Suche                            (z)");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Regaleinträge anzeigen           (a)\n");
            Console.WriteLine("Neuer Regaleintrag               (b)\n");
            Console.WriteLine("Regaleintrag ändern              (c)\n");
            Console.WriteLine("Regaleintrag löschen             (d)");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Produkteinträge anzeigen         (e)\n");
            Console.WriteLine("Neuer Produkteintrag             (f)\n");
            Console.WriteLine("Produkteintrag ändern            (g)\n");
            Console.WriteLine("Produkteintrag löschen           (h)");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Regale mit Produkten auflisten   (i)");
        }

        public static void getinput()
        {
            string input;
            char auswahl;

            Console.Write("Wählen sie einen Menüpunkt:       ");
            input = Console.ReadLine();

            auswahl = Convert.ToChar(input);
            Console.WriteLine("Ihre Auswahl:                     {0}", auswahl);

            progress(auswahl);
        }

        public static void progress(char auswahl)
        {
            switch (auswahl)
            {
                case 'z':
                    break;
                case 'a':
                    break;
                case 'b':
                    break;
                case 'c':
                    break;
                case 'd':
                    break;
                case 'e':
                    break;
                case 'f':
                    break;
                case 'g':
                    break;
                case 'h':
                    break;
                case 'i':
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe");
                    getinput();
                    break;
            }
        }
    }
}
