using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida que el operador ingresado sea valido, si no lo es devuelve +
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Operador validado</returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            switch (operador)
            {
                case "-":
                    retorno = "-";
                    break;
                case "*":
                    retorno = "*";
                    break;
                case "/":
                    retorno = "/";
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// Retorna una operacion entre dos numeros
        /// </summary>
        /// <param name="num1">Primer numero de la operacion</param>                                               
        /// <param name="num2">Segudo numero de la operacion</param>
        /// <param name="operador">Operacion a realizar</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1,Numero num2,string operador)
        {
            double resultado;

            operador = ValidarOperador(operador);
            
            switch (operador)
            {
                case "-":
                    resultado = num1 - num2;
                    break;          
                case "*":           
                    resultado = num1 * num2;
                    break;          
                case "/":           
                    resultado = num1 / num2;
                    break;          
                default:            
                    resultado = num1 + num2;
                    break;
            }

            return resultado;
        }
    }
}
