using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar() {
            var nota = 7.0;
            bool bomComportamento = false;
            var resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine("Sua nota: {0}", nota);
            Console.WriteLine("Status: {0}", resultado);
        }
    }
}
