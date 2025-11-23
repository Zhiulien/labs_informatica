using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2RegEspr
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading regular expression from the console 
            Console.WriteLine("Ora inserisci l'espressione regolare da utilizzare");
            string regepr = Console.ReadLine();

            // Declaration of an empty list
            List<string> names = new List<string>();

            Console.WriteLine("Inseriamo gli alunni");
            Console.WriteLine("---------- ---------- ---------- ---------- ---------- ---------- ");
            while (true)
            {
                Console.WriteLine("Inserisci il nome dell'alunno");
                string currentEnteredName = Console.ReadLine();

                names.Add(currentEnteredName);

                Console.WriteLine("Se vuoi finire di inserire i nomi, inserisci 'y', e se vuoi continuare, inserisci 'enter'");
                string continueInput = Console.ReadLine();
                if ("y".Equals(continueInput))
                {
                    break;
                }
            }
            Console.WriteLine("---------- ---------- ---------- ---------- ---------- ---------- ");
            string enteredNames = string.Join(", ", names);
            Console.WriteLine("Filtriamo gli alunni: " + enteredNames);
            Console.ReadKey();
        }
    }
}
