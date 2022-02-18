using System;

namespace Aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para executar basta retirar o comentario da função desejada.

            //POR EXEMPLO: abaixo vai ser executado apenas  o OperadorLogico.

            OperadorLogico();
            //EntradaDeDados();
            //SaidaDeDados();
            //RespostaExercicio1();
            //condicaoIF();
        }


        static void OperadorLogico()
        {

            //OPERADOR LOGICO.

            // CONDIÇÃO E = && 

            // A PRIMEIRA CONDICAO TEM SER VERDADEIRA E A SEGUNDA TBM.

            bool analise = 2 > 3 && 4 != 5;

            // NAO (FALSE) 

            // TRUE    -  TRUE .

            bool analise2 = !(2 > 3) && 4 != 5;

            //Console.WriteLine(analise); // FALSO
            // Console.WriteLine(analise2); //VERDADEIRO


            String nome = "lucas";
            String nome2 = "igor";

            ///            nome == LUCAS E nao nome igual a igor.

            bool nomeVerdade = (nome == "lucas");

            Console.WriteLine(nomeVerdade); //TRUE;


            bool nomeVerdade1 = (nome2 == "igor");
            Console.WriteLine(nomeVerdade1); //TRUE;

            //&& -> todas as codicoes devem ser TRUE.
            bool nomeVerdade2 = !(nome == "lucas" && nome == "igor");
            Console.WriteLine("testar aqui: " + nomeVerdade2); //FALSE;


            bool nomeVerdade3 = (nome != nome2);
            Console.WriteLine(nomeVerdade3); //TRUE;

            // || OU -> uma das condições deve ser TRUE.

            bool nomeVerdade4 = (nome == "lucas" || nome == "igor");
            Console.WriteLine(nomeVerdade4); //TRUE;


        }
        static void EntradaDeDados()
        {

            //ENTRADA DE DADOS.

            Console.WriteLine("Digite o seu nome");

            // Console.ReadLine(); // O PROGRAMA VAI LER O QUE FOI DIGITADO NO TECLADO E AGUARDAR A TECLAR ENTER.

            //leitura da linha que o usuario digitou.
            string usuario = Console.ReadLine(); //Lucas
            Console.WriteLine("Nome informado: " + usuario);





        }
        static void SaidaDeDados()
        {

            //SAIDA DE DADOS.

            int idade = 20;
            double saldo = 10.35784;
            string nome = "Maria";
            string nome1 = "João";

            //PLACEHOUDER - lugar para colocar a variavel.
            //{0} - posição;

            //Maria tem 20 anos e tem saldo igual a 10.35784 reais;

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais.", nome, idade, saldo);

            //interpolação.
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a  " + saldo + " reais.");


            Console.WriteLine(saldo);

            //convertendo int para string.
            Console.WriteLine(saldo.ToString("F2")); //deixa com 2 casas e arredonda pra cima.

            //convertendo int para string.
            Console.WriteLine(saldo.ToString("F3")); //deixa com 3 casas e arredonda pra cima.





        }
        static void RespostaExercicio1()
        {


            //Exercicio 1 

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            /*

            Usando os valores das variáveis, produza a seguinte saída na tela do console:

            Produtos:
                Computador, cujo preço é $ 2100,00
            Mesa de escritório, cujo preço é $ 650,20

            Registro: 30 anos de idade, código 5290 e gênero M


            Medida com oito casas decimais: 53,23456700
            Arredondado(três casas decimais): 53,235
             */

            //Atalho CW tab + tab.
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é {1}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é {1}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código é {1} e gênero: {2} ", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com duas casas decimais: {0}", medida.ToString("F2"));
            Console.WriteLine("Medida com duas casas decimais: {0:F2}", medida);

            //CRTL + D  duplicar linha.

            string numero = "20";
            int numero1 = int.Parse(numero);

            //substring.

        }
        static void condicaoIF()
        {


            //IF - SE
            int x = 10;
            Console.WriteLine("Bom dia");

            if (x != 5) //se a condição for verdadeira executa o bloco de código.
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");

        }


    }
}
