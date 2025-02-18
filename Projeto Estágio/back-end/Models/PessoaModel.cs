using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace back_end.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [JsonIgnore]
        public DateTime DataNascimento { get; set; }

        public int Idade
        {
        get
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Year;

                // Ajusta a idade se ainda não fez aniversário neste ano
                if (DataNascimento.Date > hoje.AddYears(-idade))
                {
                    idade--;
                }

                return idade;
            }
        }
    }
}