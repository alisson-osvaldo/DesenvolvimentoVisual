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

        private readonly DataContext _context; //para outro método poder receber o ( DataContext context) / readonly apenas para leitura
        public ProdutoController( DataContext context)
        {
            _context = context;
        }

        // POST: api/produto/Create
        [HttpPost] //Se não colocar nd ele é Get por padrão
        [Route("create")]
        //Métodos
        public Produto Create (Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges( ); //salva todas as mudanças que foram feitas
            return produto;
        }


         // GET: api/produto/list
        [HttpGet] //Se não colocar nd ele é Get por padrão
        [Route("list")]
        //Métodos
        public List<Produto> List ( ) =>  _context.Produtos.ToList( );

    }
}