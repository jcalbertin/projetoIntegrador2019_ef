using System;
using projetoIntegrador2019_ef.Modelos;

namespace projetoIntegrador2019_ef
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bd = new TurmaContext()) {
                var Turma = new Turma {
                     Ano = 2019,
                     Curso = "SI"
                };
                bd.Add(Turma);
                bd.SaveChanges();
                Console.WriteLine(" Inclusao realizada!");
            }
        }
    }
}
