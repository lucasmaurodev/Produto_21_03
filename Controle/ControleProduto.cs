using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Util;
//using WindowsFormsApp1.Util;

namespace WindowsFormsApp1.Controle
{


    internal class ControleProduto
    {
        Produto produtoModel;

        public ControleProduto(string nome, string preco, string quantidade)
        {
            var PrecoConvertido = UtilsProduto.DoubleVerificar(preco);
            var QuantidadeConvertido = UtilsProduto.IntVerificar(quantidade);

            produtoModel = new Produto(nome, PrecoConvertido, QuantidadeConvertido);


        }

        public string BuscarProduto()
        {
           return produtoModel.ProdutoDispo(); 
            
        }

        public string TotalEstoque()
        {

            return produtoModel.TotalEstoque().ToString();
        
        } 


    }
}
