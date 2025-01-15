using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyWeatherApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public DataController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        
       [HttpGet("currency")]
public async Task<IActionResult> GetCurrency(string baseCurrency, string targetCurrency)
{
    string apiUrl = $"https://v6.exchangerate-api.com/v6/773b690da2475e38fbe1d87c/latest/{baseCurrency}";
    var response = await _httpClient.GetAsync(apiUrl);

    if (!response.IsSuccessStatusCode)
        return BadRequest("Erro ao buscar os dados de câmbio.");

    var data = await response.Content.ReadAsStringAsync();
    return Ok(data);
}
public async Task<IActionResult> GetCurrency(string baseCurrency, string targetCurrency)
{
    string apiKey = $"http://api.weatherapi.com/v1/current.json?key= 921469fff377437a847224034251501&q=Brazil&aqi=no{targetCurrency}";
    var response = await _httpClient.GetAsync(apiUrl);

    if (!response.IsSuccessStatusCode)
        return BadRequest("Erro ao buscar os dados de previsão do tempo.");

    var data = await response.Content.ReadAsStringAsync();
    return Ok(data);
}
