using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC
{
    internal class Aluno
    {
        //Atributos
        int Id { get; set; }
        string Nome { get; set; }

        public Aluno (int id, string nome)
        {
            Id = id;
            Nome = nome;
        }


        public bool PodeMatricular (Curso curso)
        {
            return true;
        }
    }
}
