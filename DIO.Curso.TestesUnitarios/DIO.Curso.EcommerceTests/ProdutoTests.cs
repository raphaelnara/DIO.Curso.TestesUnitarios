using DIO.Curso.Ecommerce;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DIO.Curso.EcommerceTests
{
    [TestClass]
    public class ProdutoTests
    {
        [TestMethod]
        public void EqualTest()
        {
            var produto1 = new Produto { Codigo = "00000X1", Nome = "Videogame" };
            var produto2 = new Produto { Codigo = "00000X1", Nome = "Videogame" };

            Assert.AreEqual(produto1, produto2);
        }
    }
}
