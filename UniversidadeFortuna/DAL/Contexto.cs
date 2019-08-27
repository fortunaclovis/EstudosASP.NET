using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UniversidadeFortuna.Models;

namespace UniversidadeFortuna.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Contexto") { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}