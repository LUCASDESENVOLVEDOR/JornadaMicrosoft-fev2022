using ClosedXML.Excel;
using System;
using System.IO;
using System.Linq;

namespace Aula_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LeituraExcel();

            //LeituraTxt();
        }


        static void LeituraExcel()
        {


            //LER UM BANCO DE DADOS (EXCEL)

            //ClosedXML biblioteca importada pelo NUGET.

            string caminho = @"C:\Users\Lucas - Senai\Desktop\AULA_07\banco_de_dados.xlsx";

            //XLWorkBook
            XLWorkbook xls = new XLWorkbook(caminho);

            //leitura da plan1, primeira aba do excel.
            IXLWorksheet planilha = xls.Worksheets.First(tabela => tabela.Name == "Plan1");

            int totaLinhas = planilha.RowCount();

            for (int i = 2; i < 10; i++)
            {
                //consulta a coluna a partir de cada linha representada pelo I.
                var nome = planilha.Cell($"A{i}").Value.ToString();

                Console.WriteLine(nome);
            }


            //novo registro.
            planilha.Cell("A3").Value = "Bruno";
            planilha.Cell("B3").Value = "30";
            planilha.Cell("C3").Value = "Nova especialidade";

            xls.SaveAs(caminho);


            //finalizar a comunicao = referete ao close();            
            xls.Dispose();


        }



        static void LeituraTxt()
        {

            //ler dados de arquivo local.

            string enderecoDoArquivo = @"C:\Users\Lucas - Senai\Desktop\AULA_07\dados.txt";

            //caminho e o que vamos fazer.
            FileStream arquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            //classe que vai ler o stream para nós.
            StreamReader leitor = new StreamReader(arquivo);

            // while = enquato.

            //leitor.EndOfStream  =  terminou de ler.
            // EndOfStream = false;
            //EndOfStream =  true;


            //! = enquanto estiver lendo
            while (!leitor.EndOfStream)
            {
                // mostre linha por linha que esta lendo.

                string linha = leitor.ReadLine();

                //novo Profissional

                Profissional novoProfissional = ConverterStringParaProfissional(linha);


                string mensagem = ($"Nome:{ novoProfissional.nome}, Idade: { novoProfissional.idade}, Especialidade: {  novoProfissional.especialidade  }");


                //Lucas 28 Dados

                Console.WriteLine(mensagem);
            }


            arquivo.Close();
            leitor.Close();
        }



        //vamos criar uma funcao.

        static Profissional  ConverterStringParaProfissional(string linha)
        {
            //"Lucas 28 Dados"           

            string[] campos = linha.Split(' ');

            string nome = campos[0];
            int idade = int.Parse(campos[1]);
            string especialidade = campos[2];

            Profissional profissional = new Profissional();

            profissional.nome = nome;
            profissional.idade = idade;
            profissional.especialidade = especialidade;

            return profissional;
        }



        class Profissional
        {
            //get = leitura da propriedade;
            //set = setar/armazenar o valor da propriedade;

            public string nome { get; set; }

            // prop + TAB TAB
            public int idade { get; set; }

            public string especialidade { get; set; }
        }


    }
}
