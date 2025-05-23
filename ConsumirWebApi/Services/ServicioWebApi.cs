using ConsumirWebApi.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace ConsumirWebApi.Services
{
    public class ServicioWebApi : IServicioWebApi
    {
        private string urlApi = "https://rickandmortyapi.com/api/character";

        public async Task<List<Personaje>> Obtener()
        {
            var cliente = new HttpClient();
            var respuesta = await cliente.GetAsync(urlApi);
            var respuestaCuerpo = await respuesta.Content.ReadAsStringAsync();

            JsonNode nodos = JsonNode.Parse(respuestaCuerpo);
            JsonNode results = nodos["results"];

            var personajesData = JsonSerializer.Deserialize<List<Personaje>>(results.ToString());

            return personajesData;
        }
    }
}
