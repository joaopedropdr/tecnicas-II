using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Repositories;

namespace TodoApi.Controllers
{
    // Define que essa classe é uma api    
    [ApiController]
    // Difine a rota desse controller
    [Route("api/[controller]")]
    public class TarefasController : Controller
    {
        private readonly TarefaRepository _repository;
        public TarefasController(TarefaRepository tarefaRepository)
        {
            _repository = tarefaRepository;
        }
        [HttpGet]
        // Para usar a API, criamos o ActionResult para garantir que o retorno do banco seja de um unico tipo
        public async Task<ActionResult<List<Tarefa>>> Get()
        {
            var tarefas = await _repository.ObterTodasTarefasAsync();
            return Ok(tarefas);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Tarefa tarefa)
        {
            await _repository.CriarTarefaAsync(tarefa);
            return CreatedAtAction(nameof(Get), new {id = tarefa.Id}, tarefa);
        }

    }
}
