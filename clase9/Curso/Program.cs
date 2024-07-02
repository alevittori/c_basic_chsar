using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Podemos usar la palabra recervada var para declarar variables implicitas, 
             * La palabra clave var no indica un tipo especial de variable. Es una forma abreviada sintáctica de cualquier
             * tipo que el compilador pueda inferir a partir de la inicialización de una declaración de variable.
             * 
             * */

            var unValor = ""; // toma el tipo string
            var otroValor = 1.1; // toma el tipo double
            var unNumero = 1; // toma tipo entero 

            Console.WriteLine($"Primer valor: {unValor} ");

            Console.WriteLine($"Segundo valor: {otroValor}");

            unValor = "puto";
            Console.WriteLine($"Ahora Primer valor vale = {unValor}");

            Console.WriteLine($"un numero {unNumero} del tipo: {unNumero.GetType()} ");
            Console.WriteLine($"un numero {unNumero} del tipo: {unNumero.GetType()} le sumamos un doble 1.5 {unNumero + 1.5} ahora quedo del tipo { unNumero.GetType()}");

            Console.ReadKey();
        }
    }
}
