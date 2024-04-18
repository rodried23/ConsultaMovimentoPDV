using ConsultaMovimentoPDV.Models;

namespace ConsultaMovimentoPDV.Services
{
    public interface IMovimentoInterface
    {
        Task<ResponseModel<MovimentoModel>> BuscarMovimento(Guid id);
    }
}
