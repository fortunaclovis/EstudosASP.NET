using System;
using System.Collections.Generic;
using UniversidadeFortuna.Models;

namespace UniversidadeFortuna.DAL
{
    public class UniversidadeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var alunos = new List<Aluno>
            {
            new Aluno{Nome="Carson",Sobrenome="Alexander",DataInscricao=DateTime.Parse("2005-09-01")},
            new Aluno{Nome="Meredith",Sobrenome="Alonso",DataInscricao=DateTime.Parse("2002-09-01")},
            new Aluno{Nome="Arturo",Sobrenome="Anand",DataInscricao=DateTime.Parse("2003-09-01")},
            new Aluno{Nome="Gytis",Sobrenome="Barzdukas",DataInscricao=DateTime.Parse("2002-09-01")},
            new Aluno{Nome="Yan",Sobrenome="Li",DataInscricao=DateTime.Parse("2002-09-01")},
            new Aluno{Nome="Peggy",Sobrenome="Justice",DataInscricao=DateTime.Parse("2001-09-01")},
            new Aluno{Nome="Laura",Sobrenome="Norman",DataInscricao=DateTime.Parse("2003-09-01")},
            new Aluno{Nome="Nino",Sobrenome="Olivetto",DataInscricao=DateTime.Parse("2005-09-01")}
            };

            alunos.ForEach(s => contexto.Alunos.Add(s));
            contexto.SaveChanges();
            var cursos = new List<Curso>
            {
            new Curso{CursoId=1050,Titulo="Chemistry",Creditos=3,},
            new Curso{CursoId=4022,Titulo="Microeconomics",Creditos=3,},
            new Curso{CursoId=4041,Titulo="Macroeconomics",Creditos=3,},
            new Curso{CursoId=1045,Titulo="Calculus",Creditos=4,},
            new Curso{CursoId=3141,Titulo="Trigonometry",Creditos=4,},
            new Curso{CursoId=2021,Titulo="Composition",Creditos=3,},
            new Curso{CursoId=2042,Titulo="Literature",Creditos=4,}
            };
            cursos.ForEach(s => contexto.Cursos.Add(s));
            contexto.SaveChanges();
            var inscricoes = new List<Inscricao>
            {
            new Inscricao{AlunoId=1,CursoId=1050,Grade=Grade.A},
            new Inscricao{AlunoId=1,CursoId=4022,Grade=Grade.C},
            new Inscricao{AlunoId=1,CursoId=4041,Grade=Grade.B},
            new Inscricao{AlunoId=2,CursoId=1045,Grade=Grade.B},
            new Inscricao{AlunoId=2,CursoId=3141,Grade=Grade.F},
            new Inscricao{AlunoId=2,CursoId=2021,Grade=Grade.F},
            new Inscricao{AlunoId=3,CursoId=1050},
            new Inscricao{AlunoId=4,CursoId=1050,},
            new Inscricao{AlunoId=4,CursoId=4022,Grade=Grade.F},
            new Inscricao{AlunoId=5,CursoId=4041,Grade=Grade.C},
            new Inscricao{AlunoId=6,CursoId=1045},
            new Inscricao{AlunoId=7,CursoId=3141,Grade=Grade.A},
            };
            inscricoes.ForEach(s => contexto.Inscricoes.Add(s));
            contexto.SaveChanges();
        }
    }
}