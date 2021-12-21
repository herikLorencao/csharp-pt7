using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente contaCorrente)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = contaCorrente;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
                return;

            int novoTamanho = _itens.Length * 2;

            if (novoTamanho < tamanhoNecessario)
                novoTamanho = tamanhoNecessario;

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }

            _itens = novoArray;
        }
    }
}
