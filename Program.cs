
using Aula34MVC.Controllers;

namespace Aula34MVC
{
    class Program
    {
        static void Main(string[] args)

        {
           ProdutoController produto = new ProdutoController();
         
           produto.Listar();
           produto.Filtrar("199");

        


           
        }
    }

}   
