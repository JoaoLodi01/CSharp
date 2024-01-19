using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() { 
            
        }
    }
    
    internal class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "Audi";
            carro1.Modelo = "RS6 Avant";
            carro1.Ano = 2022;

            Console.WriteLine("{0} {1} {2}", carro1.Fabricante, carro1.Modelo, carro1.Ano);

            var carro2 = new Carro("Golf", "Volkswagen", 2002);
            Console.WriteLine("{0} {1} {2}", carro2.Fabricante, carro2.Modelo, carro2.Ano);

            var carro3 = new Carro() { 
                Fabricante = "Volkswagen",
                Modelo = "Jetta GLI",
                Ano = 2022
            };
            Console.WriteLine("{0} {1} {2}", carro3.Fabricante, carro3.Modelo, carro3.Ano);
        }
    }
}
