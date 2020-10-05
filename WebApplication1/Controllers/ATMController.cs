using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ATMAPI.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ATMAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ATMController : ControllerBase
    {
        private readonly IPinService _context;

        public ATMController(IPinService context)
        {
            _context = context;
        }

        // GET: api/ToDoes
        [HttpGet]
       // public async Task<ActionResult<IEnumerable<IPinService>>> GetToDos()
        //{
          //  return await _context.GetService<IPinService>();  
        //}

        // GET: api/ToDoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IPinService>> GetToDo(long id)
        {
            var toDo = await _context.ToDos.FindAsync(id);

            if (toDo == null)
            {
                return NotFound();
            }

            return toDo;
        }

        // PUT: api/ToDoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDo(long id, IPinService toDo)
        {
            if (id != toDo.ID)
            {
                return BadRequest();
            }

            _context.Entry(toDo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoExists(id))
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

        // POST: api/ToDoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<IPinService>> PostToDo(IPinService toDo)
        {
           // Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<IPinService> entityEntry = _context.ToDos.Add(toDo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetToDo), new { id = toDo.ID }, toDo);
        }

        // DELETE: api/ToDoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IPinService>> DeleteToDo(long id)
        {
            var toDo = await _context.ToDos.FindAsync(id);
            if (toDo == null)
            {
                return NotFound();
            }

            _context.ToDos.Remove(toDo);
            await _context.SaveChangesAsync();

            return toDo;
        }

        private bool ToDoExists(long id)
        {
            return _context.ToDos.Any(e => e.ID == id);
        }
    }
}
