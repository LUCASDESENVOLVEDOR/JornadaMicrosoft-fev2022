using System;

namespace Aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Para executar basta retirar o comentario da função desejada.

            //POR EXEMPLO: abaixo vai ser executado apenas  o IFSimples.

            IFSimples();
            //IFElse();
            // IFElseIf();
            //Switch();
            //SwitchCase();
            // While();
            // DoWhile();


        }

        static void IFSimples()
        {

            //IF - SE - IF SIMPLES
            int x = 10;
            Console.WriteLine("Bom dia");

            if (x != 5) //se a condição for verdadeira executa o bloco de código.
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");


        }

        static void IFElse()
        {

            //CRIE UM PROGRAMA QUE VAI RECEBER UM NUMERO 
            //E INFORMAR SE O NUMERO É PAR OU IMPAR

            Console.WriteLine("Entre com um número inteiro");

            //converter string para int.

            int numero = int.Parse(Console.ReadLine());

            //Testar se é par ou impar.

            //divide por 2 e recupera o resto da divisao.
            if (numero % 2 == 0) //se
            {
                Console.WriteLine("Par!");
            }
            else  //senao
            {
                Console.WriteLine("Impar!"); //executou pq a primeira condição é FALSO.
            }


        }

        static void IFElseIf()
        {

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());



            //if(hora < 12)
            //{
            //    Console.WriteLine("Bom dia!");
            //}

            //if(hora >= 12  && hora < 18)
            //{
            //    Console.WriteLine("Boa tarde!");
            //}

            //if (hora >= 18)
            //{
            //    Console.WriteLine("Boa noite!");
            //} 

            //ENCADEAMENTO
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }


            //DICA - se o if ou o else tiver apenas 1 linha nao precisa de  {}
            if (hora < 12)
                Console.WriteLine("Bom dia!");

            else if (hora < 18)
                Console.WriteLine("Boa tarde!");

            else
                Console.WriteLine("Boa noite!");




        }

        static void Switch()
        {
            //SWITCH  - chavear.

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());


            switch (hora)  //int , string
            {
                case < 12: Console.WriteLine("Bom dia!"); break;
                case < 18: Console.WriteLine("Boa tarde!"); break;
                default: Console.WriteLine("Boa Noite!"); break;
            }



        }

        static void SwitchCase()
        {
            int tempo = 0;
            char escolha;


            Console.WriteLine("São Paulo/SP a Belo Horizonte/MG");
            Console.WriteLine("Escolha o transporte: [a]=Avião | [c]=Carro | [o]=Onibus");

            escolha = char.Parse(Console.ReadLine().ToLower());  //.ToLower() o que o usuario digitar
                                                                 //mudar para minusculo.

            switch (escolha)
            {
                case 'a': // caso o valor da escolha for a.
                    tempo = 50;
                    break;

                case 'c':
                    tempo = 480;
                    break;

                case 'o':
                    tempo = 660;
                    break;

                default:
                    tempo = -1; break;
            }


            if (tempo < 0)
            {
                Console.WriteLine("Transporte indisponível");
            }
            else
            {
                Console.WriteLine("Para o transporte escolhido o tempo é: {0}", tempo);
            }
        }

        static void While()
        {

            //WHILE = ENQUANTO.

            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            while (numero != 0) //enquanto a condicao for TRUE, FAÇA o bloco de codigo.
            {
                soma = soma + numero;
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A soma dos valores é: {0}", soma);
            Console.ReadLine(); //Esperar enter para a sair;


        }

        static void DoWhile()
        {
            // DO WHILE;
            int numero = 45;

            do //faça.
            {
                Console.WriteLine(numero);
                ++numero; //1 por vez;
            }
            while (numero <= 50); // enquanto o numero for menor que 50 FACA;

            //OUTRO EXEMPLO DO WHILE.

            do
            {
                Console.WriteLine("Digitar um número");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi {0}", numero);
            }
            while (numero != 10);


        }


    }



}
