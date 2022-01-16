using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DIO.Curso.Ecommerce.Tests
{
    [TestClass()]
    public class PedidoTests
    {
        [TestMethod()]
        public void Ctor_Usuario_e_Produto_Test()
        {
            var usuario = new Usuario { Id = 1, NomeUsuario = "Raphael" };
            var produto = new Produto { Codigo = "00000X1", Nome = "Videogame" };

            var pedido = new Pedido(usuario, new[] { produto });

            Assert.AreSame(pedido.Solicitante, usuario);
            Assert.AreSame(pedido.Produtos[0], produto);
        }

        [TestMethod()]
        public void Ctor_ParametrosUsuario_e_Produto_Test()
        {
            var usuario = new Usuario { Id = 1, NomeUsuario = "Raphael" };
            var produto = new Produto { Codigo = "00000X1", Nome = "Videogame" };

            var pedido = new Pedido(usuario, new[] { produto });

            Assert.AreSame(pedido.Solicitante, usuario);
            Assert.AreSame(pedido.Produtos[0], produto);
        }
    }
}