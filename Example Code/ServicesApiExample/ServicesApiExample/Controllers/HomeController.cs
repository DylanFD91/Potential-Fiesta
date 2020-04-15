using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServicesApiExample.Contracts;
using ServicesApiExample.Data;
using ServicesApiExample.Models;

namespace ServicesApiExample.Controllers
{
    public class HomeController : Controller
    {
        private IWeatherRequest _weatherRequest;
        public HomeController(IWeatherRequest weatherRequest)
        {
            _weatherRequest = weatherRequest;
        }

        public async Task<IActionResult> Index()
        {
            CurrentWeather weather = await _weatherRequest.GetCurrentWeather();
            return View(weather);
        }

    }
}
