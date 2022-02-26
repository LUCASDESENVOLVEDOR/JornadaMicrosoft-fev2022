using console_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_mvc.Views
{
    internal class ProdutoView
    {

        public void Listar(List<Produto> listadosprodutos)
        {

            foreach (Produto item in listadosprodutos)
            {
                Console.WriteLine($"Código : {  item.Codigo }");
                Console.WriteLine($"Nome : {  item.Nome }");
                Console.WriteLine($"Preço : {  item.Preco }");       
            }
        }
    }
}
