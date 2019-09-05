namespace projetoIntegrador2019_ef.Modelos
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome {get; set; }
        public string RA { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }

    }
}