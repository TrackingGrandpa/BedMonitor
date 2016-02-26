using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Does it do how we do? yes or no");
            string yesorno = Console.ReadLine();
            if (yesorno == "yes")
            {
                Console.WriteLine("yay!");
            }
            else if (yesorno == "no")
                Console.WriteLine("why not?");

            else
                Console.WriteLine("awwww :(");

            Console.Write("Press enter to continue");
            Console.Read();
        }
    }
}
