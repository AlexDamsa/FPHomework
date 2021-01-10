using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static bool GetInt (this ref int instance)
        {
            if (int.TryParse(Console.ReadLine(), out instance))
            {
                return true;
            }

            Console.Write("try again: ");
            return instance.GetInt();
        }

        public static int Lenght(this int instance)
        {
            if (instance != 0)
            {
                return 1 + (instance / 10).Lenght();
            }

            return 0;
        }

        #region Methods implemented for pool2

        


        #endregion
    }
}
