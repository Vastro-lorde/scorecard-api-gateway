using System;

namespace scorecard_portal.Controllers
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; internal set; }
        public string Summary { get; set; }
    }
}