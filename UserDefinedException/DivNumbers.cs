using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    class DivNumbers : IDivide
    {
        int result;
        public DivNumbers()
        {
            result = 0;
        }

        public void Division(int num1, int num2)
        {
            try
            {
                result = num1/num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e.Message);
            }
            finally
            {
               Console.WriteLine("Result : {0}", result);
            }
        }
    }
}
