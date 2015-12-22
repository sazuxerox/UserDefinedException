using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new DivNumbers();
            d.Division(24, 4);
            d.Display();

            var t = new Temparature();
            try
            {
                t.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TimeIsZeroException : {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
