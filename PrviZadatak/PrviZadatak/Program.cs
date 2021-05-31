using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;

            Console.Write("Upisite jedan broj: ");
            broj = Convert.ToInt32(Console.ReadLine());

            if (broj % 4 == 0 && broj%6!=0)
            {
                Console.WriteLine("Broj je djeljiv sa 4");
            }
            if (broj%6==0 && broj % 4 != 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6");
            }
            if (broj % 6 == 0 && broj % 4 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6 i sa 4");
            }
            if (broj % 6 != 0 && broj % 4 != 0)
            {
                Console.WriteLine("Broj nije djeljiv sa 6 i sa 4");
            }

            Console.ReadKey();

        }
    }
}
