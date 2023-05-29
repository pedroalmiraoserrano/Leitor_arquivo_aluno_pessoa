using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoasealunosnowindowsoforms
{
    internal class Aluno : Pessoa
    {
        public List<string> Curso { get; set; }

        public Aluno()
        {
            Curso = new List<string>();
        }
    }
}
