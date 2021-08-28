using System;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase //fazendo com que o ProdutoController erde de ControllerBase(vai me da suporte da parte web)
    {

        public ProdutoController( DataContext context)
        {
            
        }

        // POST: api/produto/Create
        [HttpPost] //Se não colocar nd ele é Get por padrão
        [Route("create")]
        //Métodos
        public Produto Create (Produto produto)
        {
            DataContext context = new DataContext(null);
            Console.WriteLine(produto);
            produto.Nome += " Alterado";
            return produto;
        }
    }
}