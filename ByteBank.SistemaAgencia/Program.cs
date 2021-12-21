using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContasCorrentes lista = new ListaDeContasCorrentes();

            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));

            Console.WriteLine("A execução do programa foi finalizada, tecle enter para finalizar ...");
            Console.ReadLine();
        }

        private static void TestarArray()
        {
            int[] idades = new int[]
            {
                10,
                20,
                30,
                40,
                50
            };

            int acumulador = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine($"Idade do indice {i}: {idades[i]}");
                acumulador += idades[i];
                Console.WriteLine(idades[i]);
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"A média das idades é {media} anos");
        }
    }
}
