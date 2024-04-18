using ConsultaMovimentoPDV.Data;
using ConsultaMovimentoPDV.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultaMovimentoPDV.Services
{
    public class NfceSerieService : INfceSerieInterface
    {
        private readonly AppDbContext _context;
        public NfceSerieService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<NfceSerieModel>> BuscarNfceSerie(Guid id)
        {
            ResponseModel<NfceSerieModel> resposta = new ResponseModel<NfceSerieModel>();
            try
            {
                var nfceSerie = await _context.NfceSerie.FirstOrDefaultAsync(nfceSerieBanco => nfceSerieBanco.Cod_NFE_Serie == id);

                if (nfceSerie == null)
                {
                    resposta.Mensagem = "Nenhum resgitro encontrado!";
                    return resposta;
                }


                resposta.Dados = nfceSerie;
                resposta.Mensagem = "NFCE Serie Localizado!";

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
