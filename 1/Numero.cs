using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Numero
    {
        int num1;
        int num2;
        int Resultado;
        string salida;
        public  Numero ()
        {
                            

        }
        public int OperarSuma (int num1, int num2)
        {

            Resultado = num1 + num2;
            return Resultado;

        }
        public String MostrarResultado ()
        {
            salida = "El numero " + num1 + " + " + num2 + " = " + Resultado;
            return salida;

        }
    }
}
