using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaculdadeApp;

namespace FaculdadeApp
{
    [TestClass]
    public class FaculdadeAppTest
    {
        [TestMethod]
        public void AdicionarAluno_Test()
        {
            // Arrange
            FaculdadeApp.FaculdadeApp faculdade = new FaculdadeApp.FaculdadeApp();
            Aluno aluno = new Aluno { Nome = "Maria", Matricula = "2024001" };

            // Act
            faculdade.AdicionarAluno(aluno);
            var alunos = faculdade.ListarAlunos();

            // Assert
            Assert.IsTrue(alunos.Contains(aluno));
        }

        // Adicione outros métodos de teste aqui conforme necessário
    }
}
