using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Inventory
    {
        private Dictionary<string, int> products;

        public Inventory()
        {
            products = new Dictionary<string, int>();
        }

        public void AdicionarProduto(string nome, int quantidade)
        {
            products.Add(nome, quantidade);
        }

        public int ObterQuantidade(string nome)
        {
            return products.TryGetValue(nome, out int quantidade) ? quantidade : 0;
        }
    }
}
