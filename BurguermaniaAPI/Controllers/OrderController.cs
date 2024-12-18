using Microsoft.AspNetCore.Mvc;
using BurguermaniaAPI.Data;
using BurguermaniaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguermaniaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly BurguermaniaDbContext _context;

        public OrdersController(BurguermaniaDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders
                .Include(o => o.Status)
                .Include(o => o.OrderProducts)
                .Include(o => o.UserOrders)
                .ToListAsync();
        }

        // GET: api/Orders/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders
                .Include(o => o.Status)
                .Include(o => o.OrderProducts)
                .Include(o => o.UserOrders)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest("Order is null.");
            }

            // Validar o modelo
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Adicionar o pedido ao contexto
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Retornar o pedido criado com o status 201 Created
            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order);
        }

        // PUT: api/Orders/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Orders/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}