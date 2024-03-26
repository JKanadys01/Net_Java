using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Weather_API
{
    internal class WeatherData
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public double Temperature { get; set; }
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
    }
}
