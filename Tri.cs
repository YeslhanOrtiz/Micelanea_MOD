using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micelanea_MOD
{
    public class Tri
    {
        public static int tri(string valorentrada)
        {
            try
            {
                int retorno;
                retorno = (int)Convert.ToDouble(valorentrada);
                return retorno;
            }
            catch (FormatException)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("El dato ingresado no es valido");
                return -1;
            }
        }
    }
}
