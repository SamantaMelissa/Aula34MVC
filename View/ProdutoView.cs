using System.Collections.Generic;
using Aula34MVC.Model;
using System;

namespace Aula34MVC.View
{
    public class ProdutoView
    {


        public void MostrarNoConsole(List<Produto> lista){
            foreach(Produto item in lista)
            {
                Console.WriteLine($"R${item.Preco} - {item.Nome}");
            }
        }
    }
}