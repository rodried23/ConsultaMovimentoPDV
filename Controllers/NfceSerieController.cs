using ConsultaMovimentoPDV.Models;
using ConsultaMovimentoPDV.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaMovimentoPDV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NfceSerieController : ControllerBase
    {
        private readonly INfceSerieInterface _nfceSerieInterface;
        public NfceSerieController(INfceSerieInterface nfceSerieInterface)
        {
            _nfceSerieInterface = nfceSerieInterface;
        }

        [HttpGet("BuscarNfceSerie/{Id}")]
        public async Task<ActionResult<ResponseModel<MovimentoModel>>> BuscarNfceSerie(Guid Id)
        {
            var nfceSerie = await _nfceSerieInterface.BuscarNfceSerie(Id);
            return Ok(nfceSerie);
        }

    }
}
