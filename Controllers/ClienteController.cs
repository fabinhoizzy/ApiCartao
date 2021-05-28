using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CartaoApi.Models;
using CartaoApi.Data;

namespace CartaoApi.Controllers
{
    public class ClienteController
    {
        //Aqui criaremos as Rotas e os Metodos GET E POST 
        [ApiController]
        [Route("v1/clientes")]
        //Route v1/cliente e a mesma coisa de https://localhost:5001/v1/clientes

        public class ClienteController : ControllerBase
        {
            [httpGet]
            [Route("")]
            public async Task<ActionResult<List<Cliente>>> Get([FromServices] DataContext context)
            {
                var clientes = await context.Clientes.ToListAsync();
                return clientes;
            }

            [httpPost]
            [Route("")]
            public async Task<ActionResult<Cliente>> Post(
                [FromServices] DataContext context, //aqui pegaremos do DataContex para ser injetado
                [FromBody] Cliente model ) // aqui está as informaçoes que vem do corpo
            {
                if (ModelState.IsValid) //aqui vai verficar se as validações estão corretas 
                {
                    context.Clientes.Add(model);    //aqui sera adicionado se tudo ocorre bem
                    await context.SaveChangesAsync(); // aqui e pra salvar as informacoes em memoria lembra do EF.
                    return model;
                }
                else
                {
                    return BadRequest(ModelState); //aqui e para tratar o erro
                }
            }
        }

    }
}