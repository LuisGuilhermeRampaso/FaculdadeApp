using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaculdadeApp
{
    using System;
    using System.Collections.Generic;

    public class FaculdadeApp
    {
        private List<Aluno> alunos;
        private List<Professor> professores;
        private List<Disciplina> disciplinas;

        public FaculdadeApp()
        {
            alunos = new List<Aluno>();
            professores = new List<Professor>();
            disciplinas = new List<Disciplina>();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public void RemoverAluno(Aluno aluno)
        {
            alunos.Remove(aluno);
        }

        public List<Aluno> ListarAlunos()
        {
            return alunos;
        }

        public void AdicionarProfessor(Professor professor)
        {
            professores.Add(professor);
        }

        public void RemoverProfessor(Professor professor)
        {
            professores.Remove(professor);
        }

        public List<Professor> ListarProfessores()
        {
            return professores;
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            disciplinas.Add(disciplina);
        }

        public void RemoverDisciplina(Disciplina disciplina)
        {
            disciplinas.Remove(disciplina);
        }

        public List<Disciplina> ListarDisciplinas()
        {
            return disciplinas;
        }
    }

}
