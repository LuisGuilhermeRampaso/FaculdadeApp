using NUnit.Framework;
using FaculdadeApp;

namespace TestProject1
{
    public class FaculdadeAppTest
    {
        private FaculdadeApp.FaculdadeApp faculdade;

        [SetUp]
        public void Setup()
        {
            faculdade = new FaculdadeApp.FaculdadeApp();
        }

        [Test]
        public void AdicionarAluno_Test()
        {
            // Arrange
            Aluno aluno = new Aluno { Nome = "Maria", Matricula = "2024001" };

            // Act
            faculdade.AdicionarAluno(aluno);
            var alunos = faculdade.ListarAlunos();

            // Assert
            Assert.IsTrue(alunos.Contains(aluno));
        }

        
    }
}
