using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
            
        }
    }

    class Temparature
    {
        int temperature = 0;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature Found"));
            }
            else
            {
                Console.WriteLine("Temperature : {0}", temperature);
            }
        }
    }
}
