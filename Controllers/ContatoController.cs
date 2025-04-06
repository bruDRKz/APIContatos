using AgendaAPI.Data;
using AgendaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgendaAPI.Controllers
{
    [ApiController] //Indica que é um controller de API
    [Route("api/[controller]")] //defino minha rota da API antes da construção da classe

    public class ContatoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ContatoController(AppDbContext context)
        {
            _context = context;
        }


        //GET: api/contato

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contato>>> GetContatos()
        {
            return await _context.Contatos.ToListAsync();
        }

        //GET: api/contato/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Contato>> GetContato(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);

            if (contato == null)
            {
                return NotFound();
            }
            else
            {
                return contato;
            }

        }
        //POST: api/contato
        [HttpPost]
        public async Task<ActionResult<Contato>> PostContato([FromBody] Contato contato)
        {
            _context.Contatos.Add(contato);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContato), new { id = contato.Id }, contato);
        }

        //PUT: api/contato/id
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContato(int id, [FromBody] Contato contatoAtt)
        {
            if (id != contatoAtt.Id)
            {
                return BadRequest("Os contatos não conferem");
            }

            else
            {
                _context.Entry(contatoAtt).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Contatos.Any(c => c.Id == id))
                    {
                        return NotFound();
                    }

                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarContato(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);
            if (contato == null) return NotFound();

            else
            {
                _context.Contatos.Remove(contato);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}
