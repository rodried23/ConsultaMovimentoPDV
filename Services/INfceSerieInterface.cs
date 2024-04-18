using ConsultaMovimentoPDV.Models;

namespace ConsultaMovimentoPDV.Services
{
    public interface INfceSerieInterface
    {
        Task<ResponseModel<NfceSerieModel>> BuscarNfceSerie(Guid id);
    }
}
