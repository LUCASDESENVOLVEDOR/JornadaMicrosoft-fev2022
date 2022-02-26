using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_mvc.Models
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //const representa um valor único, não poder ser alterado.
        private const string Path = "Database/Produto.csv";

        // CTRL + K + D (arrumar o codigo);

        //CSV (Valores separado por vírgula).


        //CONSTRUTOR   -> quando a classe for construída, o que será executado.

        //Atalho para criar o construtor.

        //CTOR TAB + TAB

        public Produto()
        {

            //split =: responsavel por separar uma string.

            string pasta = Path.Split('/')[0];

            //se a pasta NAO existe.
            if (!Directory.Exists(pasta))
            {
                //criar a pasta no projeto
                Directory.CreateDirectory(pasta);
            }

            //se o arquivo NAO existe.
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }


        //metodo publico chamado Ler que vai retornar uma lista de produtos.
        public List<Produto> ler()
        {
            List<Produto> produtos = new List<Produto>();

            //de um arquivo leia todas as linhas.          
            
            string[] linhas =  File.ReadAllLines(Path);

            //realizar a leitura de todas as linhas.
            foreach (string item in linhas)
            {
                //1;Xbox;6.744,99
                string[] atributos = item.Split(";");

                Produto novoProduto = new Produto();
                novoProduto.Codigo = int.Parse(atributos[0]);
                novoProduto.Nome = atributos[1];
                novoProduto.Preco = float.Parse(atributos[2]);

               
                //adicionando um novo produto na lista.
                produtos.Add(novoProduto);

            }

            return produtos;

        }


    }
}
