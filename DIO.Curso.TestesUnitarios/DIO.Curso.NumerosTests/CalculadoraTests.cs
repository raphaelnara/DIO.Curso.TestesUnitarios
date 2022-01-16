using DIO.Curso.Numeros;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DIO.Curso.Numeros.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        [TestMethod()]
        [DataRow(1, 1, 2)]
        [DataRow(2, 1, 3)]
        [DataRow(1, 4, 5)]
        [DataRow(5, 5, 10)]
        public void SomarTest(int n1, int n2, int retornoEsperado)
        {
            var instancia = new Calculadora();
            var retorno = instancia.Somar(n1, n2);

            Assert.IsTrue(retorno == retornoEsperado);
        }

        [TestMethod()]
        public void SubtrairTest()
        {
        }

        [TestMethod()]
        public void MultiplicarTest()
        {
        }
    }
}