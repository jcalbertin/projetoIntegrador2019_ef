using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

                //obtem automaticamente o Id quando inserido
                Console.WriteLine("Turma inserida - codigo: {0} ", Turma.Id);

                var contador = 1;
                var Aluno = new Aluno();
                Aluno.RA = "A234_" + (contador++).ToString();
                Aluno.Nome = "Pedro Silva";
                Aluno.Turma = Turma;
                bd.Add(Aluno);
                bd.SaveChanges();

               
                var Aluno2 = new Aluno();
                Aluno2.RA = "A211-" + (contador++).ToString();
                Aluno2.Nome = "Maria";
                Aluno2.Turma = Turma;
                bd.Add(Aluno2);
                bd.SaveChanges();

                //modifico uma entidade alterando algum atributo e salvando mudancas
                Turma.Ano = 2020;
                bd.SaveChanges();

                foreach( var aluno in Turma.Alunos)
                    Console.WriteLine ("Aluno na turma {0} : RA {1} - Nome: {2}", Turma.Id, aluno.RA, aluno.Nome);

                //deletando o aluno2
                Console.WriteLine("Deletando o aluno de RA {0} - nome: {1} ", Aluno2.RA, Aluno2.Nome);
                bd.Remove(Aluno2);
                bd.SaveChanges();

                foreach( var aluno in Turma.Alunos)
                    Console.WriteLine ("Aluno restante na turma {0} : {1}", Turma.Id, aluno.Nome);
                
                //encontra uma turma conforme seu id
                //equivalente a: select * from turma where id = 2  
                var TurmaProcurada = bd.Turmas.Find(2);
                Console.WriteLine("Turma procurada - Id: {0} - Curso: {1}", TurmaProcurada.Id, TurmaProcurada.Curso );

                //procuras mais avançadas - exemplos

                //procura todas as turma cujo curso contem a letra S
                //equivalente a: select * from turma where curso like '%S%'
                var resultado = bd.Turmas
                        .Where(t => EF.Functions.Like(t.Curso, "%S%"))
                        .ToList();
                foreach (var t in resultado) {
                    Console.WriteLine("achados {0} " , t.Curso);
                }

                //pode usar SQL se preferir, ele já volta o objeto preenchido
                var TurmaSQL = bd.Turmas.FromSql("SELECT * FROM dbo.Turmas WHERE Curso LIKE '%' + @p0 + '%'", "S").Where(x => x.Ano == 2019).ToList();
                TurmaSQL.ForEach(entidade => Console.WriteLine("ID: " + entidade.Id));
            
            }
        }
    }
}
