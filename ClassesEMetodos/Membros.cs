using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar() { 
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "João";
            sicrano.Idade = 18;

            //Console.WriteLine("{0} tem {1} anos", sicrano.Nome, sicrano.Idade);

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Vitor";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
