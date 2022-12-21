using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Helpers
{
    public static class ExtensionTask
    {
        public static int ExtensionIntType(this int num1)
        {
            int hasil = 1;
            for (int i = 1; i <= num1; i++)
            {
                hasil = hasil * i;

            }
            return hasil;
        }
    }
}
