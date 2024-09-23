using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC
{
    internal class Escola
    {
        private List<Curso> cursos = new List<Curso>();

        public bool AdicionarCurso(Curso curso)
        {
            if (cursos.Count < 5)
            {
                cursos.Add(curso);
                return true;
            }
            return false;
        }

        public Curso PesquisarCurso(int id)
        {
            return cursos.Find(c => c.Id == id);
        }

        public bool RemoverCurso(Curso curso)
        {
            if (cursos.Contains(curso) && curso.GetDisciplinas().Count == 0)
            {
                cursos.Remove(curso);
                return true;
            }
            return false;
        }

        public List<Curso> GetCursos()
        {
            return cursos;
        }



    }
}
