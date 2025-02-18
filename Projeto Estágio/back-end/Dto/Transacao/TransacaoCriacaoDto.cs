using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Models;

namespace back_end.Dto.Transacao
{
    public class TransacaoCriacaoDto
{
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public bool Tipo { get; set; }
    public int PessoaId { get; set; }
}
}