using System;

namespace Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Para executar basta retirar o comentario da função desejada.
            //POR EXEMPLO: abaixo vai ser executado apenas inicio.

            inicio();
            // OperadorAritimetico();
            //Atribuicao();
            // OperadorRelacional();

        }

        static void inicio()
        {
            //COMO DECLARAR UMA VARIAVEL.
            // TIPO depois o NOME ; <- no final de todas as linhas.

            //linha verde = a variavel criada não esta sendo utilizada.

            //linha vermelha = esta falando algo, vai dar erro de compilação.

            // 1 sinal de igual representa atribuição.


            //comentários. 

            /*             
                comentario para mais de uma 
                linha.               
            */

            //Declarar uma variavel? 
            //tipo   nomedavariavel  

            string name;
            int idade;

            //Para atribuir um valor em uma variavel.
            // utilizamos o sinal de = 

            name = "Lucas";
            idade = 28;

            Console.WriteLine(name);

            //arrumar o codigo, CRTL + K + D;     

        }

        static void OperadorAritimetico()
        {
            //tipo //nome da variavel // sinal de = representa atribuição;
            int numero1 = 1;
            int numero2 = 30;
            int numero3 = 20;


            // + juntar o texto com o numero.    //parenteses conta, + (soma)
            //soma de todas as variaveis do tipo int.
            Console.WriteLine("Soma de todos os numeros: " + (numero1 + numero2 + numero3));

            //comando para duplicar a linha atual. CRLT + D;
            //subtração  de todas as variaveis do tipo int.
            Console.WriteLine("Substração: " + (numero3 - numero2 - numero1));
            //multiplicação  de todas as variaveis do tipo int.
            Console.WriteLine("Multiplicação: " + (numero3 * numero2 * numero1));
            //divisão  de todas das variaveis do tipo int.
            Console.WriteLine("Divisão: " + (numero3 / numero2));




        }

        static void Atribuicao()
        {
            //Atribuição.

            int a = 10;

            Console.WriteLine(a);
            Console.WriteLine("-----------------------");



            //a = a + 2;


            //10 + 2 
            //representa a atribuição de A para =>  A + 2;
            a += 2;

            Console.WriteLine(a);
            Console.WriteLine("-----------------------");

            //representa a atribuição de ABC para =>  ABC + DEF;
            string palavra = "ABC";
            palavra += "DEF";
            Console.WriteLine(palavra);


            //const = nao pode mudar.
            const string palavra2 = "Lucas";




        }

        static void OperadorRelacional()
        {

            int a = 10;


            //bool => tipo de variavel que armazena informações TRUE OU FALSE.
            bool c1 = a < 10; //resposta sempre será TRUE OU FALSE.

            bool c2 = a <= 20; //menor igual
            bool c3 = a >= 10; //maior igual

            bool c4 = a == 10; // a é igual a 10
            bool c5 = a != 10; // a é diferente de 10.



            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);

        }


    }
}
