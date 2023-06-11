using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraRm
{
    public static class Operators
    {
        public static double CalculateOperators(double n1, double n2, string operationCalc)
        {
            double result = 0;

            switch (operationCalc)
            {
                case "÷":
                    result = n1 / n2;
                    break;
                case "−":
                    result = n1 - n2;
                    break;
                case "×":
                    result = n1 * n2;
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                default:
                    break;
            }

            return result; //retorna el resultado de la operacion del case que se ha seleccionado
        }
    }
}

