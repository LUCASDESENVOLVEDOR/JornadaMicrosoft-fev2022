using EJOGOS.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{

    //: representa a herança;
    //interface = contrato.
    public class Equipe : EquipeBase, IEquipe
    {
        //construtor

        //ctor TAB TAB
        public Equipe()
        {
            //metodo da classe de herança;
            CriarPastaOuArquivo(caminho);
        }

        //prop TAB TAB

        //duplicar linha ctrl + D  

        public int IdEquipe { get; set; }
        public string nome { get; set; }
        public string Imagem { get; set; }

        //variavel de dados.

        //private nivel de acesso.
        // const = constante = a variavel nao pode mudar.

        private const string caminho = "Database/equipe.csv";

        private string Preparar(Equipe e)
        {
            return $"{e.IdEquipe};{e.nome};{e.Imagem}";
        }

        public void Criar(Equipe novaequipe)
        {

            //preparar a classe para retornar um texto.

            //array de strings   =  na posicao 0 vai existir nossa linha.
            string[] equipe_texto = { Preparar(novaequipe) };

            //arquivo vamos adicionar novas linhas.
            //caminho , string formato de array.
            File.AppendAllLines(caminho, equipe_texto);
        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listadeEquipes = new List<Equipe>();

            //pegar o texto e adicionar na classe.

            string[] linhas = File.ReadAllLines(caminho);

            //adicionar a classe na lista
            foreach (string item in linhas)
            {
                // 1;NOME DO TIME; CAMINHO DA IMAGEM

                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.IdEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listadeEquipes.Add(equipeAtual);
            }

            //devolver a lista;
            return listadeEquipes;

        }
    }
}
