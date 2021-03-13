using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace registro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        private readonly AplicationDBContext _context;
        public RegistroController(AplicationDBContext context)
        {
            _context = context;
        }
        // GET: api/<RegistroController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listRegistros = await _context.Registro.ToListAsync();
                return Ok(listRegistros);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<RegistroController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var registro = await _context.Registro.FindAsync(id);
                if (registro == null)
                {
                    return NotFound();
                }
                return Ok(registro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<RegistroController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Registro registro)
        {
            try
            {
                _context.Add(registro);
                await _context.SaveChangesAsync();
                return Ok(registro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<RegistroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegistroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
