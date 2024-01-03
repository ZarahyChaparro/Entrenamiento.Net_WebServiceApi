using Microsoft.AspNetCore.Mvc;
using WebServiceApi.Modelo;

namespace WebServiceApi.Controller
{
    [Route("api/suma")]
    [ApiController]
    public class SumaController
    {
        [HttpGet]
        [Route("sumar")]
        public ActionResult<ProcedimientoSuma> Sumar(int numero1, int numero2)
        {
            ProcedimientoSuma calculadora = new ProcedimientoSuma(numero1, numero2);
            calculadora.suma();

            return calculadora;
        }
    }
}
