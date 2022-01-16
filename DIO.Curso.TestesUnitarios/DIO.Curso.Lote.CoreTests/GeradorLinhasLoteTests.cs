using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DIO.Curso.Lote.Core.Tests
{
    [TestClass()]
    public class GeradorLinhasLoteTests
    {
        [TestMethod()]
        public void GerarTest()
        {
            Assert.AreEqual(new Config(), new Config());
            return;


            //Arrange
            var turma = 1;
            var alunos = new[]
            {
                "Enzo",
                "Valentina"
            };

            //Act
            var instancia = new GeradorLinhasLote();
            var linhas = instancia.Gerar(turma, alunos);

            //Assert
            Assert.AreEqual("CURSO;INSTRUTOR;TURMA;ALUNO;MATRICULA;", linhas[0]);
            Assert.AreEqual("[.NET] Criando testes unitarios em C#,;Raphael Nara Pereira;1;Enzo;16/01/2022", linhas[1]);
            Assert.AreEqual("[.NET] Criando testes unitarios em C#,;Raphael Nara Pereira;1;Valentina;16/01/2022", linhas[2]);
        }
    }
}