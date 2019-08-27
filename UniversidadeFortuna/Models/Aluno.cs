using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversidadeFortuna.Models
{
    public class Aluno
    {
       
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [Display(Name = "Data de Inscrição")]
        [DataType(DataType.Date)]
        public DateTime DataInscricao { get; set; }

        public virtual ICollection<Inscricao> Inscricoes { get; set; }
    }
}