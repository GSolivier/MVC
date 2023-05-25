using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";

        //criar um construtor

        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);                
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produto = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
               string[] atributos =  item.Split(";");
               Produto p = new Produto();

               p.Codigo = int.Parse(atributos[0]);
               p.Nome = atributos[1];
               p.Preco = float.Parse(atributos[2]);

               produto.Add(p);
            }

            return produto;
        }

        public string PrepararLinhaCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhaCSV(p)};

            File.AppendAllLines(PATH,linhas);

        }

    }
}