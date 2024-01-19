using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC
            double peso = 94.3;
            double altura = 1.85;
            double IMC = peso / Math.Pow(altura, 2); // (altura * altura) ou Math.Pow(altura, 2) para inserir expoente
            Console.WriteLine($"IMC é {IMC}.");

            // Número Par/Impar
            int par = 22;
            int impar = 23;
            Console.WriteLine("{0} / 2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0} / 2 tem resto {1}", impar, impar % 2);
        }
    }
}
