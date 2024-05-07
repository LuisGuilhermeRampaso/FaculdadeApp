using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaculdadeApp;

namespace FaculdadeApp
{
    [TestClass]
    public class FaculdadeAppTests
    {
        [TestMethod]
        public void AdicionarAluno_Test()
        {
            // Arrange
            FaculdadeApp faculdade = new FaculdadeApp(); // Adicionando a declaração e instanciando FaculdadeApp
            Aluno aluno = new Aluno { Nome = "Maria", Matricula = "2024001" };

            // Act
            faculdade.AdicionarAluno(aluno);
            var alunos = faculdade.ListarAlunos();

            // Assert
            Assert.IsTrue(alunos.Contains(aluno));
        }

        // Outros métodos de teste podem ser adicionados aqui
    }
}
