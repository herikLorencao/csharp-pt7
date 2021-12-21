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
            TestaListaGenerica();

            Console.WriteLine("A execução do programa foi finalizada, tecle enter para finalizar ...");
            Console.ReadLine();
        }

        private static void TestaListaGenerica()
        {
            Lista<int> lista = new Lista<int>();

            lista.Adicionar(5);
            lista.Adicionar(6);
            lista.Adicionar(7);
            lista.Adicionar(8);

            lista.Exibir();
        }

        private static void TestaListaContas()
        {
            ListaDeContasCorrentes lista = new ListaDeContasCorrentes();
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(100, 123567),
                new ContaCorrente(101, 355677),
                new ContaCorrente(102, 687949),
            };

            lista.AdicionarVarios(contas);
            lista.Exibir();
        }

        private static void TestaLista()
        {
            ListaDeContasCorrentes lista = new ListaDeContasCorrentes();
            ContaCorrente contaRemocao = new ContaCorrente(555, 5555555);

            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(new ContaCorrente(123, 123567));
            lista.Adicionar(contaRemocao);

            lista.Exibir();
            Console.WriteLine("-----------------------------");
            lista.Remover(contaRemocao);
            lista.Exibir();
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
