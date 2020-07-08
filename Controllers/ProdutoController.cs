using System.Collections.Generic;
using Aula34MVC.Model;
using Aula34MVC.View;

namespace Aula34MVC.Controllers
{
    //Vamos instanciar o model e o view
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        
        ProdutoView produtoView = new ProdutoView();

        Produto dado1 = new Produto();
        
        Produto dado2 = new Produto();
        Produto dado3 = new Produto();
        Produto dado4 = new Produto();
        Produto dado5 = new Produto();

        public void Listar(){
             produtoView.MostrarNoConsole( produtoModel.Ler() );
        }

        public void Filtrar(string _preco){
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x=> x.Preco == float.Parse(_preco));
            produtoView.MostrarNoConsole(lista);
        }

    }
}