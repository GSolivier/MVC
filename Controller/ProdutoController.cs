using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula1.Model;
using Aula1.View;

namespace Aula1.Controller
{
    public class ProdutoController
    {
        Produto p = new Produto();
        ProdutoView pw = new ProdutoView();

        public void ListarProdutos()
        {
           List<Produto> lista = p.Ler();

           pw.Listar(lista);
        }

        public void CadastrarProduto()
        {
            Produto novoProduto = pw.Cadastrar();

            p.Inserir(novoProduto);
        }
    }
}
