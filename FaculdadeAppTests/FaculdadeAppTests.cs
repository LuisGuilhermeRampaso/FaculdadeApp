using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaculdadeApp;

namespace FaculdadeAppTests
{
    [TestClass]
    public class FaculdadeAppTests
    {
        [TestMethod]
        public void AdicionarAluno_Test()
        {
            // Arrange
            FaculdadeApp faculdade = new FaculdadeApp();
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

