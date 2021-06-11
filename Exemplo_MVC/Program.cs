using System;
using Exemplo_MVC.Controllers;
using Exemplo_MVC.Models;

namespace Exemplo_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();

            prod.Cadastrar();

            prod.ListaProduto();
        }
    }
}
