using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUDApi.Data;
using CRUDApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {

        private readonly AlumnoDB _context;

        public AlumnosController(AlumnoDB context)
        {
            _context = context;
        }

        //TODOS LOS REGISTROS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlumnosM>>> GetAlumnosItems()
        {
            return await _context.AlumnosItem.ToListAsync();
        }

        //SOLO UN REGISTRO
        [HttpGet("{id}")]
        public async Task<ActionResult<AlumnosM>> GetAlumnosItems(int id)
        {

            var alumnosItem = await _context.AlumnosItem.FindAsync(id);

            if (alumnosItem == null) {

                return NotFound();
            }
            return alumnosItem;
        }

        //INSERTAR
        [HttpPost]
        public async Task<ActionResult<AlumnosM>> PostAlumnosItem(AlumnosM item)
        {
            _context.AlumnosItem.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAlumnosItems), new { id = item.id }, item);

        }


        //ACTUALIZAR
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumnosItem(int id, AlumnosM item)
        {

            if (id != item.id)
            {
                return BadRequest();

            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();

        }


        //DELETE

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumnoItem(int id) 
        {

            var alumnoItem = await _context.AlumnosItem.FindAsync(id);

            if (alumnoItem == null) 
            { 
            return NotFound();
            }

            _context.AlumnosItem.Remove(alumnoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}
