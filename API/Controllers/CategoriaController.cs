using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/categoria")]
    public class CategoriaController : ControllerBase
    {
        private readonly DataContext _context; //para outro método poder receber o ( DataContext context) / readonly apenas para leitura
        public CategoriaController( DataContext context)
        {
            _context = context;
        }

        [HttpPost]// POST: api/categoria/Create
        [Route("create")]
        //Métodos
        public IActionResult Create ([FromBody] Categoria categoria) //vem do Body
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges( ); //salva todas as mudanças que foram feitas
            return Created("", categoria);
        }

         // GET: api/categoria/list
        [HttpGet]
        [Route("list")]
        public IActionResult List( ) =>  Ok(_context.Categorias.ToList());

    }
}