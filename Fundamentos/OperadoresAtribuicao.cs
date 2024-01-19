using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar() {
            var num1 = 3;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine("O número é: {0}", num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine("O valor de A é: {0}", a);
            Console.WriteLine("O valor de B é: {0}", b);

            dynamic  c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";   // Atribuição por referência
        }
    }
}
