using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using MongoDB.Driver;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public class TarefaRepository
    {
        private readonly IMongoCollection<Tarefa> _tarefasCollection;
        public TarefaRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MongoConnection");
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("TodoDatabase");
            _tarefasCollection = database.GetCollection<Tarefa>("Tarefas");

        }
        public async Task<List<Tarefa>> ObterTodasTarefasAsync() =>
            await _tarefasCollection.Find(_ => true).ToListAsync();
        public async Task CriarTarefaAsync(Tarefa tarefa)=>
            await _tarefasCollection.InsertOneAsync(tarefa);
    }
}
