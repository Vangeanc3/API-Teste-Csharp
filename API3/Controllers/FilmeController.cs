using API3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API3.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class FilmeController : ControllerBase
    {

        private static List<Filme> filmes = new List<Filme>();


        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
            //Console.WriteLine(filmes[0].Genero);
        }   
    }
}
