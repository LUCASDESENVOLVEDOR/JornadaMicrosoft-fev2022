using System;

namespace Aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {


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


    }
}
