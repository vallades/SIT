using MelhorPrecoSempreIT.Models;
using MelhorPrecoSempreIT.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace MelhorPrecoSempreIT.Controllers
{
    [Authorize]
    public class PratosController : ApiController
    {
        private readonly PratosDAL _pratosDAL = new PratosDAL();

        [Route("Api/GetPratos")]
        [HttpGet]
        public List<Pratos> GetPratos()
        {
            return _pratosDAL.ObterPratos();
        }

        [Route("Api/BuscaPratos")]
        [HttpPost]
        public IHttpActionResult BuscaPratos([FromBody]Pratos pratos)
        {
            if (pratos == null)
                throw new ArgumentNullException("Não foram informados os valores dos pratos para busca!");

            try
            {
                var retorno = _pratosDAL.ObterPrato(pratos);                
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("Ocorreu um problema ao processar sua solicitação: " + ex.Message);
            }            
        }
    }
}