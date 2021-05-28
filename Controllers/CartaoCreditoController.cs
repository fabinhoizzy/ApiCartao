using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CartaoApi.Models;
using CartaoApi.Data;
using CartaoApi.Controllers;

namespace CartaoApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoCreditoController : ControllerBase
    {
        private readonly DataContext _context;

        public CartaoCreditoController(DataContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartaoCredito>>> GetCartao()
        {
            return await _context.CartaoCreditos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CartaoCredito>> GetCartao(int id)
        {
            var cartao = await _context.CartaoCreditos.FindAsync(id);

            if (cartao == null)
            {
                return NotFound();
            }

            return cartao;
        }

        [HttpPost]
        public async Task<ActionResult<CartaoCredito>> PostCartaoCredito(CartaoCredito cartaoCredito)
        {
            _context.CartaoCreditos.Add(cartaoCredito);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCartaoCredito", new { id = cartaoCredito.Id }, cartaoCredito);
        }

    }
 }
