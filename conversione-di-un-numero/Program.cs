using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversione_di_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int base2, numero;

            Console.Write("iserisci base in cui convertire");
            base2 = int.Parse(Console.ReadLine());
            Console.Write("inserisci in numero da convertire:");
            numero = int.Parse(Console.ReadLine());
            string risultato = Convert.ToString(numero, base2);
            Console.WriteLine($"il numero convertito è {risultato}");
        }
    }
}
