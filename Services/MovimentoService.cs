using ConsultaMovimentoPDV.Data;
using ConsultaMovimentoPDV.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultaMovimentoPDV.Services
{
    public class MovimentoService : IMovimentoInterface
    {
        private readonly AppDbContext _context;
        public MovimentoService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<MovimentoModel>> BuscarMovimento(Guid id)
        {
            ResponseModel<MovimentoModel> resposta = new ResponseModel<MovimentoModel>();
            try
            {
                var movimento = await _context.Movimento.FirstOrDefaultAsync(movimentoBanco => movimentoBanco.Cod_Movimento == id);

                if (movimento == null)
                {
                    resposta.Mensagem = "Nenhum resgitro encontrado!";
                    return resposta;
                }


                resposta.Dados = movimento;
                resposta.Mensagem = "Movimento Localizado!";

                return resposta;
            }
            catch (Exception ex)
            {

                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;

            }
        }
    }
}
