using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace Aula34MVC.Model
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";

        public Produto(){   
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }
        public List<Produto> Ler(){
        
            List<Produto> prod = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas) {
                string[] dado = linha.Split(";");

                Produto p   = new Produto();
                p.Codigo    = Int32.Parse( (dado[0]) );
                p.Nome      = (dado[1]);
                p.Preco     = float.Parse((dado[2]) );

                prod.Add(p);
            }
            prod = prod.OrderBy(z => z.Nome).ToList();
            return prod;
        }

       public List<Produto> Filtrar(string _nome){
            return Ler().FindAll(x => x.Nome == _nome);
        }



        
      


    }
}