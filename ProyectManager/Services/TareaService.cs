using ProyectManager.Models;
using System.Text.Json;
using System.Net.Http.Json;


namespace ProyectManager.Services
{
    public class TareaService : ITareaService
    {
        private readonly HttpClient client;

        public TareaService(HttpClient httpClient)
        {
            client = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };


        public async Task<IEnumerable<Tarea>> GetAll()
        {
            string resp = await client.GetStringAsync($"Tarea");
            return JsonSerializer.Deserialize<IEnumerable<Tarea>>(resp, options);

        }
        public async Task<Tarea> GetById(int id)
        {
            string resp = await client.GetStringAsync($"Tarea/{id}");
            return JsonSerializer.Deserialize<Tarea>(resp, options);
        }
    }
}
