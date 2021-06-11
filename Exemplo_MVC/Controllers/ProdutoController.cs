using System.Collections.Generic;
using Exemplo_MVC.Models;
using Exemplo_MVC.Views;

namespace Exemplo_MVC.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();


        ProdutoViews produtoView = new ProdutoViews();

        public void ListaProduto(){
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void Cadastrar(){
            Produto produto = produtoView.CadastrarProduto();

            produto.Inserir(produto);
        }


    }
}