using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar() {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            num1++;
            Console.WriteLine(num1);

            --num1;
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2);
            Console.WriteLine("O valor de num1 é: {0} e o valor do num2 é: {1}", num1, num2);
        }
    }
}
