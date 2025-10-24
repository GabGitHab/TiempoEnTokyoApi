using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace TiempoEnTokyoApi.Controllers
{
    [ApiController]
    [Route("api/ComoEstaElTiempoEn")]
    
    public class TiempoController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TiempoController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("Tokyo")]
        public async Task<IActionResult> TiempoEnTokyo()
        {
            string apiKey = "569f7f9bf9b34946851233316252210";
            string url = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q=Tokyo&aqi=no";

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return StatusCode((int)response.StatusCode, "Error al obtener datos del clima");

            string contenido = await response.Content.ReadAsStringAsync();
            return Content(contenido, "application/json");
        }
        [HttpGet("Londres")]
        public async Task<IActionResult> TiempoEnLondres()
        {
            string apiKey = "569f7f9bf9b34946851233316252210";
            string url = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q=London&aqi=no";

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return StatusCode((int)response.StatusCode, "Error al obtener datos del clima");

            string contenido = await response.Content.ReadAsStringAsync();
            return Content(contenido, "application/json");
        }
        [HttpGet("Washington")]
        public async Task<IActionResult> TiempoEnWashington()
        {
            string apiKey = "569f7f9bf9b34946851233316252210";
            string url = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q=Washington&aqi=no";

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return StatusCode((int)response.StatusCode, "Error al obtener datos del clima");

            string contenido = await response.Content.ReadAsStringAsync();
            return Content(contenido, "application/json");
        }

        [HttpGet("CiudadAEleccion")]
        public async Task<IActionResult> TiempoEnCiudad(string ciudad)
        {
            string apiKey = "569f7f9bf9b34946851233316252210";
            string url = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q={ciudad}&aqi=no";

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return StatusCode((int)response.StatusCode, "Error al obtener datos del clima");

            string contenido = await response.Content.ReadAsStringAsync();
            return Content(contenido, "application/json");
        }
    }
}
   
