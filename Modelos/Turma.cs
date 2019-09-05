using System.Collections.Generic;

namespace projetoIntegrador2019_ef.Modelos
{
    public class Turma
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Curso { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

    }
}