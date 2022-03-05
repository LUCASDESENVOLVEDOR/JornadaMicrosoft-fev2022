using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {

        public void CriarPastaOuArquivo(string caminho)
        {
            // nomedapasta / nomedoaquivo.csv
            string pasta = caminho.Split('/')[0];

            //int total = caminho.Split('/').Length;
            //string arquivo = caminho.Split('/')[1];

            //analise se a pasta existe
            //se nao existir cria a pasta.

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }


            //analise se o arquivo existe
            // se nao existir cria o arquivo.

            if (!File.Exists(caminho))
            {
                //criar o arquivo e fechar (encerrar a comunicacao)
                File.Create(caminho).Close();
            }
        }



    }
}
