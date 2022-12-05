namespace FilmesApi.Controllers
{
    using Microsoft.AspNetCore.Mvc; //Import necessario das annotations
    using FilmesApi.Models;
    [ApiController] //Indica que a classe representa uma controller
    [Route("[controller]")] //Indica que as requisicoes serao direcionadas para a class FilmeController
    public class FilmeController : ControllerBase {

        private static List<Filmes> filmes = new List<Filmes>();

        [HttpPost]
        public void adicionaFilme([FromBody]Filmes filme) {
            filmes.Add(filme);
            Console.WriteLine($"{filme.Titulo} Foi Registrado em um request POST.");

        }

    }



}