using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab2_Weather_API
{
    internal class WeatherRepository
    {
        private  WeatherDataContex context;
        private  HttpClient client;
        public WeatherRepository()
        {
            context = new WeatherDataContex();
            client = new HttpClient();
        }

        public async Task AddWeatherData(double latitude, double longitude)
        { 
            try
            {
                string call = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid=a097ab32c9428ed51f162171a78fdc7d";
                string response = await client.GetStringAsync(call);
                // Deserializacja odpowiedzi JSON
                Root weatherData = JsonSerializer.Deserialize<Root>(response);
                // Konwersja temperatury z kelwinów na stopnie Celsiusza
                
                if (weatherData != null)
                {
                    double tempCelsius = weatherData.main.temp - 273.15;
                    double tempMinCelsius = weatherData.main.temp_min - 273.15;
                    double tempMaxCelsius = weatherData.main.temp_max - 273.15;
                    string cityName = weatherData.name;
                    int humidity = weatherData.main.humidity;
                    int pressure = weatherData.main.pressure;

                    if (!WeatherDataExists(cityName, tempCelsius, tempMinCelsius, tempMaxCelsius, humidity, pressure))
                    {
                        WeatherData weatherdataToSave = new WeatherData
                        {
                            City = cityName,
                            Temperature = tempCelsius,
                            MinTemperature = tempMinCelsius,
                            MaxTemperature = tempMaxCelsius,
                            Humidity = humidity,
                            Pressure = pressure
                        };
                        context.WeatherDatas.Add(weatherdataToSave);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Pobrane dane są już w bazie:", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Blad pobierania danych: {ex.Message}", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystapil nieoczekiwany blad: {ex.Message}", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<WeatherData> GetAllWeatherData()
        {
            return context.WeatherDatas.ToList();
        }

        public List<WeatherData> GetWeatherDataByCity(string city)
        {
            return context.WeatherDatas.Where(w => w.City == city).ToList();
        }


        public void RemoveAllWeatherData()
        {
            context.WeatherDatas.RemoveRange(context.WeatherDatas);
            context.Database.ExecuteSqlRaw("DELETE FROM sqlite_sequence WHERE name='WeatherDatas'");
            context.SaveChanges();
        }

        public void RemoveWeatherDataByCity(string CityName)
        {
            var WeatherDataToDelete = GetWeatherDataByCity(CityName);
                context.WeatherDatas.RemoveRange(WeatherDataToDelete);
                context.SaveChanges();
            
        }

        private bool WeatherDataExists(string cityName, double temperature, double minTemperature, double maxTemperature, int humidity, int pressure)
        {
            return context.WeatherDatas.Any(w =>
                w.City == cityName &&
                w.Temperature == temperature &&
                w.MinTemperature == minTemperature &&
                w.MaxTemperature == maxTemperature &&
                w.Humidity == humidity &&
                w.Pressure == pressure);
        }

        public async Task<double> GetMaxParameterValue(string parameter, string city)
        {
            double maxValue = double.MinValue;
            var weatherDataList = context.WeatherDatas.Where(w => w.City == city).ToList();
            foreach (var weather in weatherDataList)
            {
                switch (parameter.ToLower())
                {
                    case "temperature":
                        if (weather.Temperature > maxValue)
                            maxValue = weather.Temperature;
                        break;
                    case "mintemperature":
                        if (weather.MinTemperature > maxValue)
                            maxValue = weather.MinTemperature;
                        break;
                    case "maxtemperature":
                        if (weather.MaxTemperature > maxValue)
                            maxValue = weather.MaxTemperature;
                        break;
                    case "humidity":
                        if (weather.Humidity > maxValue)
                            maxValue = weather.Humidity;
                        break;
                    case "pressure":
                        if (weather.Pressure > maxValue)
                            maxValue = weather.Pressure;
                        break;
                    default:
                        throw new ArgumentException("Nieprawidłowy parametr.");
                }
            }
            return maxValue;
        }

        public async Task<double> GetMinParameterValue(string parameter, string city)
        {
            double minValue = double.MaxValue;
            var weatherDataList = context.WeatherDatas.Where(w => w.City == city).ToList();
            foreach (var weather in weatherDataList)
            {
                switch (parameter.ToLower())
                {
                    case "temperature":
                        if (weather.Temperature < minValue)
                            minValue = weather.Temperature;
                        break;
                    case "mintemperature":
                        if (weather.MinTemperature < minValue)
                            minValue = weather.MinTemperature;
                        break;
                    case "maxtemperature":
                        if (weather.MaxTemperature < minValue)
                            minValue = weather.MaxTemperature;
                        break;
                    case "humidity":
                        if (weather.Humidity < minValue)
                            minValue = weather.Humidity;
                        break;
                    case "pressure":
                        if (weather.Pressure < minValue)
                            minValue = weather.Pressure;
                        break;
                    default:
                        throw new ArgumentException("Nieprawidłowy parametr.");
                }
            }
            return minValue;
        }


    }
}
