using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Dto.Transacao;
using back_end.Models;
using back_end.Services.Transacao;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    public class TransacaoController
    {
        private readonly ITransacaoInterface _transacaoInterface;

        public TransacaoController(ITransacaoInterface transacaoInterface)
        {
            _transacaoInterface = transacaoInterface;
        }

        [HttpGet("ListarTransações")]
        public ResponseModel<List<TransacaoModel>> ListarTransacoes()
        {
            var transacoes = _transacaoInterface.ListarTransacoes();
            return transacoes;
        }

        [HttpPost("CriarTransação")]
        public ResponseModel<List<TransacaoModel>> CriarTransacao(TransacaoCriacaoDto transacaoCriacaoDto)
        {
            var transacao = _transacaoInterface.CriarTransacao(transacaoCriacaoDto);
            return transacao;
        }
    }
}