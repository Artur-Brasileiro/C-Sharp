using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using back_end.Enums;

namespace back_end.Data
{
    public class TabelaTransacoes
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TipoTransacaoEnum Tipo { get; set; }

        public int IdPessoa { get; set; }
    }
}