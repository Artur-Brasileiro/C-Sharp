using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Dto.Transacao;
using back_end.Models;

namespace back_end.Services.Transacao
{
    public interface ITransacaoInterface
    {
        ResponseModel<List<TransacaoModel>> ListarTransacoes();
        ResponseModel<List<TransacaoModel>> CriarTransacao(TransacaoCriacaoDto transacaoCriacaoDto);
    }
}