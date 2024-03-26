using Microsoft.Web.WebView2.WinForms;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2_Weather_API
{
    public partial class Form1 : Form
    {
        private WeatherRepository weatherRepository;

        public Form1()
        {
            InitializeComponent();
            weatherRepository = new WeatherRepository();
            HideLocationButtons();
            InitializeComboBox();
        }

        private void get_location_Click(object sender, EventArgs e)
        {
            ShowLocationButtons();
        }

        public void HideLocationButtons()
        {
            wroclaw_location.Visible = false;
            warsaw_location.Visible = false;
            home_location.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            longitude_textBox.Visible = false;
            latitude_textBox.Visible = false;
            give_coord.Visible = false;
        }

        public void ShowLocationButtons()
        {
            wroclaw_location.Visible = true;
            warsaw_location.Visible = true;
            home_location.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            longitude_textBox.Visible = true;
            latitude_textBox.Visible = true;
            give_coord.Visible = true;
        }

        private async void wroclaw_location_Click(object sender, EventArgs e)
        {
            await weatherRepository.AddWeatherData(51.108197, 17.059862);
            latitude_textBox.Text = "51,108197";
            longitude_textBox.Text = "17,059862";
            var latestWeather = weatherRepository.GetAllWeatherData().LastOrDefault();
            if (latestWeather != null)
            {
                show_data(latestWeather);
            }
            HideLocationButtons();
        }

        private async void warsaw_location_Click(object sender, EventArgs e)
        {
            await weatherRepository.AddWeatherData(52.2297, 21.0122);
            latitude_textBox.Text = "52,2297";
            longitude_textBox.Text = "21,0122";
            var latestWeather = weatherRepository.GetAllWeatherData().LastOrDefault();
            if (latestWeather != null)
            {
                show_data(latestWeather);
            }
            HideLocationButtons();
        }

        private async void home_location_Click(object sender, EventArgs e)
        {
            await weatherRepository.AddWeatherData(51.41777, 22.72235);
            latitude_textBox.Text = "51,41777";
            longitude_textBox.Text = "22,72235";
            var latestWeather = weatherRepository.GetAllWeatherData().LastOrDefault();
            if (latestWeather != null)
            {
                show_data(latestWeather);
            }
            HideLocationButtons();
        }

        private async void give_coord_Click(object sender, EventArgs e)
        {
            double lat = double.Parse(latitude_textBox.Text);
            double lon = double.Parse(longitude_textBox.Text);

            await weatherRepository.AddWeatherData(lat, lon);
            var latestWeather = weatherRepository.GetAllWeatherData().LastOrDefault();
            if (latestWeather != null)
            {
                show_data(latestWeather);
            }
            HideLocationButtons();
        }

        private void show_data_base_Click(object sender, EventArgs e)
        {
            var weatherDataList = weatherRepository.GetAllWeatherData();

            if (weatherDataList.Any())
            {
                Data_box.Items.Clear();
                foreach (var weather in weatherDataList)
                {
                    Data_box.Items.Add($"Id: {weather.Id} ");
                    Data_box.Items.Add($"Miasto: {weather.City}");
                    Data_box.Items.Add($"Temperatura: {weather.Temperature:F2}°C");
                    Data_box.Items.Add($"Temperatura minimalna: {weather.MinTemperature:F2}°C");
                    Data_box.Items.Add($"Temperatura maksymalna: {weather.MaxTemperature:F2}°C");
                    Data_box.Items.Add($"Wilgotnoœæ: {weather.Humidity}%");
                    Data_box.Items.Add($"Ciœnienie: {weather.Pressure} hPa");
                    Data_box.Items.Add("------------------------------------------");
                }
            }
            else
            {
                MessageBox.Show("Baza danych jest pusta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void show_data(WeatherData weather)
        {
            Data_box.Items.Clear();
            Data_box.Items.Add($"Id: {weather.Id} ");
            Data_box.Items.Add($"Miasto: {weather.City}");
            Data_box.Items.Add($"Temperatura: {weather.Temperature:F2}°C");
            Data_box.Items.Add($"Temperatura minimalna: {weather.MinTemperature:F2}°C");
            Data_box.Items.Add($"Temperatura maksymalna: {weather.MaxTemperature:F2}°C");
            Data_box.Items.Add($"Wilgotnoœæ: {weather.Humidity}%");
            Data_box.Items.Add($"Ciœnienie: {weather.Pressure} hPa");
            Data_box.Items.Add("------------------------------------------");
        }

        private void delete_database_Click(object sender, EventArgs e)
        {
            Data_box.Items.Clear();
            weatherRepository.RemoveAllWeatherData();
        }

        private void delete_by_city_button_Click(object sender, EventArgs e)
        {
            string cityName = city_name_textBox.Text;
            List<WeatherData> weatherDataList = weatherRepository.GetWeatherDataByCity(cityName);
            Data_box.Items.Clear();
            if (weatherDataList.Any())
            {
                weatherRepository.RemoveWeatherDataByCity(cityName);
            }
            else
            {
                MessageBox.Show("Nie znaleziono danych dla podanego miasta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void name_sort_Click(object sender, EventArgs e)
        {
            string cityName = city_name_textBox.Text;
            List<WeatherData> weatherDataList = weatherRepository.GetWeatherDataByCity(cityName);

            if (weatherDataList.Any())
            {
                Data_box.Items.Clear();
                foreach (var weather in weatherDataList)
                {
                    Data_box.Items.Add($"Id: {weather.Id} ");
                    Data_box.Items.Add($"Miasto: {weather.City}");
                    Data_box.Items.Add($"Temperatura: {weather.Temperature:F2}°C");
                    Data_box.Items.Add($"Temperatura minimalna: {weather.MinTemperature:F2}°C");
                    Data_box.Items.Add($"Temperatura maksymalna: {weather.MaxTemperature:F2}°C");
                    Data_box.Items.Add($"Wilgotnoœæ: {weather.Humidity}%");
                    Data_box.Items.Add($"Ciœnienie: {weather.Pressure} hPa");
                    Data_box.Items.Add("------------------------------------------");

                }
            }
            else
            {
                MessageBox.Show("Nie znaleziono danych dla podanego miasta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InitializeComboBox()
        {
            parametr_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            parametr_comboBox.Items.AddRange(new string[] { "temperature", "mintemperature", "maxtemperature", "humidity", "pressure" });
            parametr_comboBox.SelectedIndex = 0;
        }

        private async void min_max_Click(object sender, EventArgs e)
        {
            string cityName = city_name_textBox.Text;

            List<WeatherData> weatherDataList = weatherRepository.GetWeatherDataByCity(cityName);
            if (!weatherDataList.Any())
            {
                MessageBox.Show("Brak danych dla podanego miasta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedParameter = parametr_comboBox.SelectedItem.ToString();

            double minValue = await weatherRepository.GetMinParameterValue(selectedParameter, cityName);
            double maxValue = await weatherRepository.GetMaxParameterValue(selectedParameter, cityName);

            string unit = "";

            switch (selectedParameter)
            {
                case "temperature":
                case "mintemperature":
                case "maxtemperature":
                    unit = "°C";
                    break;
                case "humidity":
                    unit = "%";
                    break;
                case "pressure":
                    unit = "hPa";
                    break;
                default:
                    break;
            }
            min_max_listBox.Items.Clear();
            min_max_listBox.Items.Add($"Min {selectedParameter}: {Math.Round(minValue, 2)} {unit}");
            min_max_listBox.Items.Add($"Max {selectedParameter}: {Math.Round(maxValue, 2)} {unit}");
        }

        private void wykres_button_Click(object sender, EventArgs e)
        {
            string cityName = city_name_textBox.Text;

            List<WeatherData> weatherDataList = weatherRepository.GetWeatherDataByCity(cityName);
            if (!weatherDataList.Any())
            {
                MessageBox.Show("Brak danych dla podanego miasta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedParameter = parametr_comboBox.SelectedItem.ToString();

            // Tworzenie wykresu
            Chart chart = new Chart();
            chart.Size = new Size(600, 400);
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Add(new Series(selectedParameter));
            chart.Series[selectedParameter].ChartType = SeriesChartType.Column;

            // Dodawanie danych do wykresu
            foreach (var weather in weatherDataList)
            {
                double value = 0;
                switch (selectedParameter)
                {
                    case "temperature":
                        value = weather.Temperature;
                        break;
                    case "mintemperature":
                        value = weather.MinTemperature;
                        break;
                    case "maxtemperature":
                        value = weather.MaxTemperature;
                        break;
                    case "humidity":
                        value = weather.Humidity;
                        break;
                    case "pressure":
                        value = weather.Pressure;
                        break;
                    default:
                        break;
                }
                chart.Series[selectedParameter].Points.AddXY(weather.Id, value);
            }

            // Dostosowanie zakresu osi X
            chart.ChartAreas[0].AxisX.Minimum = weatherDataList.Min(w => w.Id) - 0.5;
            chart.ChartAreas[0].AxisX.Maximum = weatherDataList.Max(w => w.Id) + 0.5;

            // Ustawienie etykiet osi X
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            foreach (var weather in weatherDataList)
            {
                chart.ChartAreas[0].AxisX.CustomLabels.Add(weather.Id - 0.5, weather.Id + 0.5, weather.Id.ToString());
            }

            // Dodanie tytu³u i opisów osi
            chart.Titles.Add(selectedParameter);
            chart.ChartAreas[0].AxisX.Title = "ID";
            chart.ChartAreas[0].AxisY.Title = selectedParameter;

            // Wyœwietlenie wykresu w nowym oknie
            Form chartForm = new Form();
            chartForm.Text = "Wykres";
            chartForm.ClientSize = new Size(650, 450);
            chart.Dock = DockStyle.Fill;
            chartForm.Controls.Add(chart);
            chartForm.ShowDialog();

        }

        private void map_button_Click(object sender, EventArgs e)
        {
            double lat = double.Parse(latitude_textBox.Text);
            double lon = double.Parse(longitude_textBox.Text);

            string Lat = lat.ToString().Replace(',','.');
            string Lon = lon.ToString().Replace(',', '.');


            Form mapForm = new Form();
            mapForm.Text = "Map";
            mapForm.ClientSize = new Size(800, 600);

            WebView2 webView2 = new WebView2();
            webView2.Dock = DockStyle.Fill;
            webView2.Source = new Uri($"https://www.google.com/maps?q={Lat},{Lon}");

            mapForm.Controls.Add( webView2 );
            mapForm.ShowDialog();

        }
    }
}
