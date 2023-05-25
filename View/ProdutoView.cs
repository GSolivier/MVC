using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula1.Model;

namespace Aula1.View
{
    public class ProdutoView
    {
        
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Item: {item.Preco:C}");
                
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informa o código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informa o Nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informa o Preco: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
            
        }
    }
}