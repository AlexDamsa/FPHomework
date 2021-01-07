using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class ExtensionMethods
    {
        public static void GetInt(this int num)
        {
            if (int.TryParse(Console.ReadLine(), out num))
            {
                return;
            }

            num.GetInt();
        }
    }
}
