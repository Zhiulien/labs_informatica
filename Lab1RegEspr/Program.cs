using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1RegEspr
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading regular expression from the console 
            Console.WriteLine("Ora inserisci l'espressione regolare da utilizzare");
            string regepr = Console.ReadLine();

            // Creating instance of the class RegEspr and initialize regular expression
            RegEspr regEspr = new RegEspr(regepr);

            while (true)
            {
                Console.WriteLine("Inserisci la stringa su cui verificare il match");
                string input = Console.ReadLine();

                string res = regEspr.CheckMatch(input);
                Console.WriteLine("La stringa che hai inserito fa " + res);

                Console.WriteLine("Se vuoi finire, inserisci 'y', e se vuoi continuare, inserisci 'enter'");
                string continueInput = Console.ReadLine();
                if ("y".Equals(continueInput))
                {
                    Console.WriteLine("Grazie per aver usato la nostra programma");
                    break;
                }
                Console.WriteLine("---------- ---------- ---------- ---------- ---------- ---------- ");
            }
            // Console.ReadKey();
        }
    }
}
