using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Dto;
using back_end.Dto.Pessoa;
using back_end.Models; 

namespace back_end.Services.Pessoa
{
    public interface IPessoaInterface
    {
        ResponseModel<List<PessoaModel>> ListarPessoas();
        ResponseModel<List<PessoaModel>> CriarPessoa(PessoaCriacaoDto pessoaCriacaoDto);
        ResponseModel<List<PessoaModel>> ExcluirPessoa(int idPessoa);
        ResponseModel<List<TotaisDto>> ConsultarTotais();
    }
}