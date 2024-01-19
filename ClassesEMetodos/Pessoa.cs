using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format("Olá! Me chamo {0} e tenho {1} anos", Nome, Idade);
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
