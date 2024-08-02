using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Test
{
    public class InventoryTest
    {
        [Fact]
        public void AdicionarProdutoTeste()
        {
            var inventory = new Inventory();
            string nomeProduto = "Arroz";
            int quantidadeInicial = 1;
            int quantidadeAdicional = 2;

            inventory.AdicionarProduto(nomeProduto, quantidadeInicial);
            inventory.AdicionarProduto(nomeProduto, quantidadeAdicional);

            int quantidadeEsperada = 3;
            int quantidadeAtual = inventory.ObterQuantidade(nomeProduto);
            Assert.Equal(quantidadeEsperada, quantidadeAtual);
        }

    }
}
