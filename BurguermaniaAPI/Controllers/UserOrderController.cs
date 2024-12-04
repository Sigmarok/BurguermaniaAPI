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
    public class UserOrdersController : ControllerBase
    {
        private readonly BurguermaniaDbContext _context;

        public UserOrdersController(BurguermaniaDbContext context)
        {
            _context = context;
        }

        // GET: api/UserOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserOrder>>> GetUserOrders()
        {
            return await _context.UserOrders
                .Include(uo => uo.User)
                .Include(uo => uo.Order)
                .ToListAsync();
        }

        // GET: api/UserOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserOrder>> GetUserOrder(int id)
        {
            var userOrder = await _context.UserOrders
                .Include(uo => uo.User)
                .Include(uo => uo.Order)
                .FirstOrDefaultAsync(uo => uo.Id == id);

            if (userOrder == null)
            {
                return NotFound();
            }

            return userOrder;
        }

        // POST: api/UserOrders
        [HttpPost]
        public async Task<ActionResult<UserOrder>> PostUserOrder(UserOrder userOrder)
        {
            _context.UserOrders.Add(userOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserOrder), new { id = userOrder.Id }, userOrder);
        }

        // PUT: api/UserOrders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserOrder(int id, UserOrder userOrder)
        {
            if (id != userOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(userOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserOrderExists(id))
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

        // DELETE: api/UserOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserOrder(int id)
        {
            var userOrder = await _context.UserOrders.FindAsync(id);
            if (userOrder == null)
            {
                return NotFound();
            }

            _context.UserOrders.Remove(userOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserOrderExists(int id)
        {
            return _context.UserOrders.Any(e => e.Id == id);
        }
    }
}