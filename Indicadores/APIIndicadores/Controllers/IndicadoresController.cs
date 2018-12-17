using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using APIIndicadores.Models;
using Dapper;

namespace APIIndicadores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicadoresController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Indicador>), (int)HttpStatusCode.OK)]
        public IEnumerable<Indicador> Get(
            [FromServices]IConfiguration configuration)
        {
            using (SqlConnection conexao = new SqlConnection(
                configuration.GetConnectionString("BaseIndicadores")))
            {
                return conexao.Query<Indicador>(
                    "SELECT * FROM dbo.Indicadores");
            }
        }    

        [HttpGet("{indicador}")]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        public ActionResult<Indicador> Get(
            [FromServices]IConfiguration configuration,
            string indicador)
        {
            Indicador resultado = null;

            using (SqlConnection conexao = new SqlConnection(
                configuration.GetConnectionString("BaseIndicadores")))
            {
                resultado = conexao.QueryFirstOrDefault<Indicador>(
                    "SELECT * FROM dbo.Indicadores " +
                    "WHERE Sigla = @siglaIndicador",
                    new { siglaIndicador = indicador });
            }

            if (resultado != null)
                return resultado;
            else
            {
                return NotFound(
                    new {
                            Mensagem = "Indicador inválido ou inexistente."
                        });
            }
        }    
    }
}