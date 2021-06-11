using System;
using System.Collections.Generic;
using System.IO;

namespace Exemplo_MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // CONSTANTE EM CAIXA ALTA 
        private const string PATH = "Database/Produto.csv";
        // Pasta/arquivo 
        public Produto()
        {

            // separando a string ||
            //                    \/
            string pasta = PATH.Split("/")[0];

            // verifica se a pasta existe 
            if (!Directory.Exists(pasta))
            {
                // criar pasta
                Directory.CreateDirectory(pasta);

            }

            // verifica se o arquivo exixte
            if (!File.Exists(PATH))
            {
                // cria arquivo
                File.Create(PATH);
            }

        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributo = item.Split(";");

                Produto prod = new Produto();

                prod.Codigo = int.Parse(atributo[0]);
                prod.Nome = atributo[1];
                prod.Preco = float.Parse(atributo[2]);

                produtos.Add(prod);
            }
            return produtos;
        }

        public string PrepararLinhaCSV(Produto prod){

            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }

        public void Inserir(Produto produto){
            string[] linhas = {PrepararLinhaCSV(produto)};

            File.AppendAllLines(PATH,linhas);
            
        }
    }
}