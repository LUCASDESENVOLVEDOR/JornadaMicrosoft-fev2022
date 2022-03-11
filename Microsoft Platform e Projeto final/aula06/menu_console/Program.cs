using System;

namespace menu_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //usuario vai informar o que o programa deve fazer.
            //tera algumas opcoes de escolha.

            bool continuar = true;       

            //faça
            do
            {
                Console.WriteLine(@" Escolha uma opção:
                                     1 - Carro
                                     2 - Moto
                                     3 - Caminhão
                                     4 - Cadastrar
                                     5 - Sair");

                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();

                switch (opcaoEscolhida)
                {
                    case "1": Console.WriteLine("Você escolheu Carro"); break;
                    case "2": Console.WriteLine("Você escolheu Moto"); break;
                    case "3": Console.WriteLine("Você escolheu Caminhão"); break;
                    case "4": Cadastrar(); break;
                    case "5": continuar = false; break;
                    default: Console.WriteLine("Escolha não válida."); break;
                }
            } 
            
            while (continuar); //enquanto for verdadeiro faça.          


        }


        public static void Cadastrar()
        {
            Console.WriteLine("Cadastro realizado");
        }
    }
}
