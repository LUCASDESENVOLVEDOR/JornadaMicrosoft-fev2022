using console_mvc.Models;
using console_mvc.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_mvc.Controllers
{
    internal class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> listadosprodutos = produto.ler();

            produtoView.Listar(listadosprodutos);


            //metodo da classe produto que vai consultaro BD.
            //retornar uma lista de produtos.

            // produto.ler();

            //recebe uma lista de produtos, e mostra para o usuario todos os produtos.
          
           // produtoView.Listar(produto.ler());




        }




    }
}
