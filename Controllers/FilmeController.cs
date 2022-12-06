namespace FilmesApi.Controllers
{
    using Microsoft.AspNetCore.Mvc; //Import necessario das annotations
    using FilmesApi.Models;
    [ApiController] //Indica que a classe representa uma controller
    [Route("[controller]")] //Indica que as requisicoes serao direcionadas para a class FilmeController
    public class FilmeController : ControllerBase {

        private static List<Filmes> filmes = new List<Filmes>();

        private static int id;

        [HttpPost]
        public void adicionaFilme([FromBody]Filmes filme) {
            filme.Id = id++;
            filmes.Add(filme);
            Console.WriteLine($"{filme.Titulo} Foi Registrado em um request POST.");

        }

        [HttpGet] 
        public IEnumerable<Filmes> exibeFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50) {
            return filmes.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public Filmes? buscaFilmes(int id) {
            return filmes.FirstOrDefault(filme => filme.Id == id); //Funcao vai iterar buscando o filme que possui o id igual ao passado na resquisicao, caso nao encontre, o valor sera Null/Default
        }

    }



}