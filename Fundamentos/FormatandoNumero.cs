using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));    // Casa Decimais
            Console.WriteLine(valor.ToString("C"));     // Valor Monetário
            Console.WriteLine(valor.ToString("P"));     // Valor porcentagem
            Console.WriteLine(valor.ToString("#.##"));  // Casas decimais

            CultureInfo cultura = new CultureInfo("en-US");     // Formatação de cultura
            Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));  // Zeros a esquerda
        }
    }
}
