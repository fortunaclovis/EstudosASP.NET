namespace UniversidadeFortuna.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }
    public class Inscricao
    {
        public int InscricaoID { get; set; }
        public int CursoId { get; set; }
        public int AlunoId { get; set; }
        public Grade? Grade { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}