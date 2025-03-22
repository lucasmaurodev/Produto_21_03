using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Util
{
    internal class UtilsProduto
    {

       public static int IntVerificar(string Total)
        {

            if (int.TryParse(Total, out int Intcerto))
            {

                return Intcerto;
            }
            else 
            {

                throw new ArgumentException("Valor invalido");
            
            }

        }

        public static double DoubleVerificar(string Total)
        {

            if (double.TryParse(Total, out double Doublecerto))
            {

                return Doublecerto;
            }
            else
            {

                throw new ArgumentException("Valor invalido");

            }
        }
        }
}
