using AdmibolsilloN.Data;
using AdmibolsilloN.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmibolsilloN.Controllers
{
    public class UsuarioController1 : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UsuarioController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public UsuarioController(ApplicationDbContext context)
            {
                _context = context;
            }

            // GET: api/Usuario
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
            {
                return await _context.Usuario.Include(u => u.IdTipoUsuario).ToListAsync();
            }

            // GET: api/Usuario/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Usuario>> GetUsuario(int id)
            {
                var usuario = await _context.Usuario.Include(u => u.IdTipoUsuario).FirstOrDefaultAsync(u => u.Id == id);

                if (usuario == null)
                {
                    return NotFound();
                }

                return usuario;
            }

            // POST: api/Usuario
            [HttpPost]
            public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
            {
                _context.Usuario.Add(usuario);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
            }

            // PUT: api/Usuario/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
            {
                if (id != usuario.Id)
                {
                    return BadRequest();
                }

                _context.Entry(usuario).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return NoContent();
            }

            // DELETE: api/Usuario/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteUsuario(int id)
            {
                var usuario = await _context.Usuario.FindAsync(id);
                if (usuario == null)
                {
                    return NotFound();
                }

                _context.Usuario.Remove(usuario);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
    }
    }

