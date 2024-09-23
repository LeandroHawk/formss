using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC
{
    internal class Disciplina
    {
        int Id { get; set; }
        string Descricao { get; set; }
        private List<Aluno> alunosMatriculados = new List<Aluno>();

        public Disciplina(int id, string descricao) 
        {
            Id = id;
            Descricao = descricao;
        }


        public bool MatricularAluno (Aluno aluno)
        {
            if (alunosMatriculados.Count < 15)
            {
                alunosMatriculados.Add (aluno); 
                return true;
            }
            return false;
        }


        public bool DesmatricularAluno(Aluno aluno)
        {

            return alunosMatriculados.Remove(aluno);
        }

        public List <Aluno> GetAlunosMatriculados()
        {
            return alunosMatriculados;
        }



    }
}
