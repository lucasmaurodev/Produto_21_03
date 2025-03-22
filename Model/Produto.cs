using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }

        public Produto(string Nome, double Preco, int Quantidade)
        {

            nome = Nome;
            preco = Preco;
            quantidade = Quantidade;

        }

        public double TotalEstoque()
        {

            return quantidade * preco;

        }

        public string ProdutoDispo()
        {
            if (quantidade > 0)
            {
                return $"o total é {quantidade}";

            }
            else
            {

                return "Produto não encontrado";

            }



        }

    }
}
