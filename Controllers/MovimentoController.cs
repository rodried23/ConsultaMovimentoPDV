using Microsoft.AspNetCore.Mvc;
using ConsultaMovimentoPDV.Models;
using ConsultaMovimentoPDV.Services;

namespace ConsultaMovimentoPDV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentoController : ControllerBase
    {
        private readonly IMovimentoInterface _movimentoInterface;
        public MovimentoController(IMovimentoInterface movimentoInterface)
        {
            _movimentoInterface = movimentoInterface;
        }

        [HttpGet("BuscarMovimento/{Id}")]
        public async Task<ActionResult<ResponseModel<MovimentoModel>>> BuscarMovimento(Guid Id)
        {
            var movimento = await _movimentoInterface.BuscarMovimento(Id);
            return Ok(movimento);
        }

    }
}
