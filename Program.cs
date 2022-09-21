using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primszamkeres
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.WriteLine("Kérek egy számot: ");
            int n=Convert.ToInt32(Console.ReadLine());
            bool nemprim = false;
            try
            {
                for (int i = 0; i <= szam; i++)
                {
                    if (n%szam==0)
                    {
                        nemprim = false;
                        Console.WriteLine("A(z) {0} prím szám",n);
                    }
                    else
                    {

                    }
                }
            }
            catch (FormatException)
            {

                throw;
            }
        }
    }
}
