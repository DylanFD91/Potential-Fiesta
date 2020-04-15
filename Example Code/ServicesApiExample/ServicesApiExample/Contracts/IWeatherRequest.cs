using ServicesApiExample.Models;
using System.Threading.Tasks;

namespace ServicesApiExample.Contracts
{
    public interface IWeatherRequest
    {
        Task<CurrentWeather> GetCurrentWeather();
    }
}
