using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Helpers
{
    public static class ExtInt
    {
        public static double ExtIntType(this int num1, int pow)
        {

            var result = Math.Pow(num1, pow);
            return result;
        }
    }

}





