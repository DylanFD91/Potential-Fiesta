
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServicesApiExample.Contracts;
using ServicesApiExample.Models;

namespace ServicesApiExample.Services
{
    public class WeatherRequest : IWeatherRequest
    {
        public WeatherRequest()
        {

        }

        public async Task<CurrentWeather> GetCurrentWeather()
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?zip=53074,us&units=imperial&appid={API_Keys.OpenWeatherKey}";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                CurrentWeather weather = JsonConvert.DeserializeObject<CurrentWeather>(json);
                return weather;
            }
            return null;
        }
    }
}
