using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class ModulusClass
    {
        internal static string str;
        public static void Modulus(int count, int Modulus)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i % Modulus + " " + str);// jeg skriver modulus ind her da det er total værdi den skal tælle til som er 360 og jeg har så sat count ovenover så den tæller op til 3600 hvilket vil sige den tæller til 360, 10 gange.

            }
        }
    }
}
