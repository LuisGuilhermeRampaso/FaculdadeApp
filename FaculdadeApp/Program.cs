using FaculdadeApp;
using System;

class Program
{
    static void Main()
    {
        var faculdade = new FaculdadeApp.FaculdadeApp(); // Cria uma instância da classe FaculdadeApp

        // Adicionando alunos
        Aluno aluno1 = new Aluno { Nome = "Maria", Matricula = "2024002" };
        Aluno aluno2 = new Aluno { Nome = "João", Matricula = "2024002" };
        faculdade.AdicionarAluno(aluno1);
        faculdade.AdicionarAluno(aluno2);

        // Adicionando professores
        Professor professor1 = new Professor { Nome = "Ana", Departamento = "Ciência da Computação" };
        Professor professor2 = new Professor { Nome = "Carlos", Departamento = "Engenharia Civil" };
        faculdade.AdicionarProfessor(professor1);
        faculdade.AdicionarProfessor(professor2);

        // Adicionando disciplinas
        Disciplina disciplina1 = new Disciplina { Nome = "Programação .NET", Codigo = "PROG101" };
        Disciplina disciplina2 = new Disciplina { Nome = "Cálculo", Codigo = "CALC201" };
        faculdade.AdicionarDisciplina(disciplina1);
        faculdade.AdicionarDisciplina(disciplina2);

        // Listando alunos
        Console.WriteLine("Alunos na faculdade:");
        foreach (var aluno in faculdade.ListarAlunos())
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Matrícula: {aluno.Matricula}");
        }

        // Listando professores
        Console.WriteLine("\nProfessores na faculdade:");
        foreach (var professor in faculdade.ListarProfessores())
        {
            Console.WriteLine($"Nome: {professor.Nome}, Departamento: {professor.Departamento}");
        }

        // Listando disciplinas
        Console.WriteLine("\nDisciplinas na faculdade:");
        foreach (var disciplina in faculdade.ListarDisciplinas())
        {
            Console.WriteLine($"Nome: {disciplina.Nome}, Código: {disciplina.Codigo}");
        }
    }
}
