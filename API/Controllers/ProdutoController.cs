using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase //fazendo com que o ProdutoController erde de ControllerBase(vai me da suporte da parte web)
    {

        //Banco De Dados
        private readonly DataContext _context; //para outro método poder receber o ( DataContext context) / readonly apenas para leitura
        public ProdutoController( DataContext context)
        {
            _context = context;
        }

        //Create Cliente
        [HttpPost]// POST: api/produto/Create
        [Route("create")]
        //Métodos
        public IActionResult Create ([FromBody] Produto produto) //vem do Body
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges( ); //salva todas as mudanças que foram feitas
            return Created("", produto);
        }

         // GET: api/produto/list
        [HttpGet] //Se não colocar nd ele é Get por padrão
        [Route("list")]
        public IActionResult List( ) =>  Ok(_context.Produtos.ToList());


        //Get: api/produto/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")] //aqui coloca o que quiser para busca EX: ("getbyid/{name}")...
        public IActionResult GetById([FromRoute] int id) //GetById( int ?) aqui tem q ir o mesmo q foi no Router
        //FromRoute: vem da rota
        //FromBody: vem do corpo
        {
            Produto produto = _context.Produtos.Find(id);
            if (produto == null){
                return NotFound( );
            }
            return Ok(produto);
        }

        //DELETE: /api/produto/delete/bolacha
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            //Buscar um objeto na tabela de produtos com base no nome
            Produto produto = _context.Produtos.FirstOrDefault(
                produto => produto.Nome == name  //procurando produto pelo nome na lista, irá trazer o que achar primeiro
            );
            if (produto == null)
            {
                return NotFound( );
            }
            _context.Produtos.Remove(produto); //Deletar o produto encontrado
            _context.SaveChanges( ); //Salvar
            return Ok( );
        }

        //PUT: api/produto/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return Ok(produto);
        }

    }
}