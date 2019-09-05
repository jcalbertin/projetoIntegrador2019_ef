using Microsoft.EntityFrameworkCore;

namespace projetoIntegrador2019_ef.Modelos
{
    public class TurmaContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.2.101,11433;Initial Catalog=aula1;User id=SA;Password=12MS!34#");
        }
    }
}