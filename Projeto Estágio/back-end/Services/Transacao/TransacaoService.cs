using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.Dto.Transacao;
using back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace back_end.Services.Transacao
{
    public class TransacaoService : ITransacaoInterface
    {
        private readonly AppDbContext _context;

        public TransacaoService(AppDbContext context)
        {
            _context = context;
        }

        public ResponseModel<List<TransacaoModel>> CriarTransacao(TransacaoCriacaoDto transacaoCriacaoDto)
        {
            ResponseModel<List<TransacaoModel>> retorno = new ResponseModel<List<TransacaoModel>>();

            try
            {
                var pessoa = _context.Pessoas.FirstOrDefault(pessoaBanco =>
                pessoaBanco.Id == transacaoCriacaoDto.PessoaId);

                if (pessoa == null)
                {
                    retorno.Mensagem = "Nenhum registro de pessoa localizado!";
                    return retorno;
                }

                var transacao = new TransacaoModel()
                {
                    Descricao = transacaoCriacaoDto.Descricao,
                    Valor = transacaoCriacaoDto.Valor,
                    Tipo = transacaoCriacaoDto.Tipo,
                    PessoaId = transacaoCriacaoDto.PessoaId
                };

                _context.Add(transacao);
                _context.SaveChanges();

                retorno.Dados = _context.Transacoes.ToList();
                retorno.Mensagem = "Transação adicionada com sucesso!";

                return retorno;
            }
            catch(Exception ex)
            {
                retorno.Mensagem = ex.Message;
                return retorno;
            }
        }

        public ResponseModel<List<TransacaoModel>> ListarTransacoes()
        {
            ResponseModel<List<TransacaoModel>> retorno = new ResponseModel<List<TransacaoModel>>();

            try
            {
                var transacoes = _context.Transacoes.ToList();
                retorno.Dados = transacoes;
                retorno.Mensagem = "Transações recuperadas com sucesso!";

                return retorno;
            }
            catch(Exception ex)
            {
                retorno.Mensagem = ex.Message;
                return retorno;
            }
        }
    }
}