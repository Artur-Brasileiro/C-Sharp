using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Dto;
using back_end.Dto.Pessoa;
using back_end.Models;
using back_end.Services.Pessoa;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    public class PessoaController
    { 
        private readonly IPessoaInterface _pessoaInterface;

        public PessoaController(IPessoaInterface pessoaInterface)
        {
            _pessoaInterface = pessoaInterface;
        }

        [HttpGet("ListarPessoas")]
        public ResponseModel<List<PessoaModel>> ListarPessoas()
        {
            var pessoas = _pessoaInterface.ListarPessoas();
            return pessoas;
        }

        [HttpGet("ConsultarTotais")]
        public ResponseModel<List<TotaisDto>> ConsultarTotais()
        {
            var totais = _pessoaInterface.ConsultarTotais();
            return totais;
        }

        [HttpPost("CriarPessoa")]
        public ResponseModel<List<PessoaModel>> CriarPessoa(PessoaCriacaoDto pessoaCriacaoDto)
        {
            var pessoas = _pessoaInterface.CriarPessoa(pessoaCriacaoDto);
            return pessoas;
        }

        [HttpDelete("ExcluirPessoa")]
        public ResponseModel<List<PessoaModel>> ExcluirPessoa(int id)
        {
            var pessoas = _pessoaInterface.ExcluirPessoa(id);
            return pessoas;
        }
    }
}