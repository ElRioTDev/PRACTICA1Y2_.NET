using Newtonsoft.Json;
using Proyecto.Models;
using System.Net.Http;

namespace Proyecto1.Services
{
    public class GpuService
    {
        private readonly HttpClient _httpClient;

        public GpuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Dictionary<string, Gpu>> GetGpusAsync()
        {
            var url = "https://raw.githubusercontent.com/voidful/gpu-info-api/gpu-data/gpu.json";
            var response = await _httpClient.GetStringAsync(url);

            // Convertimos el JSON en un diccionario <ID, Gpu>
            var gpus = JsonConvert.DeserializeObject<Dictionary<string, Gpu>>(response);
            return gpus;
        }
    }
}
