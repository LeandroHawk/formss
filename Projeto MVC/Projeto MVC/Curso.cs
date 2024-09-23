using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC
{
    internal class Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        private List<Disciplina> disciplinas = new List<Disciplina>();

        public Curso(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public bool AdicionarDisciplina(Disciplina disciplina)
        {
            if (disciplinas.Count < 12)
            {
                disciplinas.Add(disciplina);
                return true;
            }
            return false;
        }

        public Disciplina PesquisarDisciplina(int id)
        {
            return disciplinas.Find(d => Id == id);
        }

        public bool RemoverDisciplina(Disciplina disciplina)
        {
            if (disciplinas.Contains(disciplina) && disciplina.GetAlunosMatriculados().Count == 0)
            {
                disciplinas.Remove(disciplina);
                return true;
            }
            return false;
        }

        public List<Disciplina> GetDisciplinas()
        {
            return disciplinas;
        }
    }

}
