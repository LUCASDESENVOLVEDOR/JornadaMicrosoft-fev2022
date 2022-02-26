
using console_mvc.Controllers;
using console_mvc.Models;
using System;

namespace console_mvc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Produto  produto = new Produto();
          
            ProdutoController produtoController = new ProdutoController();

            produtoController.ListarProdutos();

        }
    }
}
