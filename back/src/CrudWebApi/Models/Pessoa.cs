using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebApi.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade  { get; set; }
        public string Profissao { get; set; }
    }
}