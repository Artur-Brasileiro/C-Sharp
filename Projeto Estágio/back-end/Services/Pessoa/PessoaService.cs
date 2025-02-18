using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.Dto;
using back_end.Dto.Pessoa;
using back_end.Models;

namespace back_end.Services.Pessoa
{
    public class PessoaService : IPessoaInterface
    {
        private readonly AppDbContext _context;
        public PessoaService(AppDbContext context)
        {
            _context = context;
        }

        public ResponseModel<List<PessoaModel>> ListarPessoas()
        {
            ResponseModel<List<PessoaModel>> retorno = new ResponseModel<List<PessoaModel>>();

            try
            {
                var pessoas = _context.Pessoas.ToList();
                retorno.Dados = pessoas;
                retorno.Mensagem = "Todas as pessoas foram coletadas!";

                return retorno;
            }
            catch(Exception ex)
            {
                retorno.Mensagem = ex.Message;
                return retorno;
            }
        }

        public ResponseModel<List<PessoaModel>> CriarPessoa(PessoaCriacaoDto pessoaCriacaoDto)
        {
            ResponseModel<List<PessoaModel>> retorno = new ResponseModel<List<PessoaModel>>();

            try
            {
                var pessoa = new PessoaModel()
                {
                    Nome = pessoaCriacaoDto.Nome,
                    DataNascimento = pessoaCriacaoDto.DataNascimento
                };

                _context.Add(pessoa);
                _context.SaveChanges();

                retorno.Dados = _context.Pessoas.ToList();
                retorno.Mensagem = "Pessoa criada com sucesso!";
                return retorno;
            }
            catch(Exception ex)
            {
                retorno.Mensagem = ex.Message;
                return retorno;
            }
        }

        public ResponseModel<List<PessoaModel>> ExcluirPessoa(int idPessoa)
        {
            ResponseModel<List<PessoaModel>> retorno = new ResponseModel<List<PessoaModel>>();

            try
            {
                var pessoa = _context.Pessoas.FirstOrDefault(pessoaBanco => pessoaBanco.Id == idPessoa);

                if (pessoa == null)
                {
                    retorno.Mensagem = "Pessoa não encontrada!";
                    return retorno;
                }

                 // Removendo todas as transações da pessoa antes de excluir
                var transacoes = _context.Transacoes.Where(t => t.PessoaId == idPessoa).ToList();
                _context.Transacoes.RemoveRange(transacoes);

                _context.Remove(pessoa);
                _context.SaveChanges();
                
                retorno.Dados = _context.Pessoas.ToList();
                retorno.Mensagem = "Pessoa removida com sucesso!";
                return retorno;
            }
            catch(Exception ex)
            {
                retorno.Mensagem = ex.Message;
                return retorno;
            }
        }

        public ResponseModel<List<TotaisDto>> ConsultarTotais()
        {
            ResponseModel<List<TotaisDto>> retorno = new ResponseModel<List<TotaisDto>>();

            try
            {
                var pessoas = _context.Pessoas.ToList();
                var totais = new List<TotaisDto>();
                decimal totalGeralReceitas = 0, totalGeralDespesas = 0, totalGeralSaldo = 0;

                foreach (var pessoa in pessoas)
                {
                    bool maiorIdade = pessoa.Idade >= 18;

                    var transacoes = _context.Transacoes.Where(t => t.PessoaId == pessoa.Id).ToList();
                    
                    decimal totalReceitas = 0, totalDespesas = 0;

                    foreach (var transacao in transacoes)
                    {
                        if (transacao.Tipo == true && maiorIdade)
                        {
                            totalReceitas += transacao.Valor;
                        }
                        else if (transacao.Tipo == false)
                        {
                            totalDespesas += transacao.Valor;
                        }
                    }

                    decimal saldo = totalReceitas - totalDespesas;
                    totais.Add(new TotaisDto
                    {
                        Nome = pessoa.Nome,
                        TotalReceitas = totalReceitas,
                        TotalDespesas = totalDespesas,
                        Saldo = saldo
                    });

                    totalGeralReceitas += totalReceitas;
                    totalGeralDespesas += totalDespesas;
                    totalGeralSaldo += saldo;
                }

                totais.Add(new TotaisDto
                {
                    Nome = "Total Geral",
                    TotalReceitas = totalGeralReceitas,
                    TotalDespesas = totalGeralDespesas,
                    Saldo = totalGeralSaldo
                });

                retorno.Dados = totais;
                retorno.Mensagem = "Totais consultados com sucesso!";
                return retorno;
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
                return retorno;
            }
        }
    }
}