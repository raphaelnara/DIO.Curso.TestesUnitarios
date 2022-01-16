using DIO.Curso.Ecommerce;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DIO.Curso.EcommerceTests
{
    [TestClass]
    public class UsuarioTests
    {
        [TestMethod]
        public void EqualTest()
        {
            var usuario1 = new Usuario { Id = 1, NomeUsuario = "Raphael" };
            var usuario2 = new Usuario { Id = 1, NomeUsuario = "Raphael" };

            Assert.AreEqual(usuario1, usuario2);
        }
    }
}
