using System.Collections.Generic;

namespace DIO.Curso.Ecommerce
{
    public class Pedido
    {
        public int Numero { get; set; }
        public Usuario Solicitante { get; set; }
        public IList<Produto> Produtos { get; set; }

        public Pedido(Usuario solicitante, IEnumerable<Produto> produtos)
        {
            Solicitante = solicitante;
            Produtos = new List<Produto>(produtos);
        }
        public Pedido(int idSolicitante, string nomeSolicitante, IEnumerable<Produto> produtos)
        {
            Solicitante = new Usuario { Id = idSolicitante, NomeUsuario = nomeSolicitante };
            Produtos = new List<Produto>(produtos);
        }
    }
}
