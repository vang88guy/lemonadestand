using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //member variables
        public List<string> weatherCondition = new List<string>() { "Sunny", "Cloudy", "Rainy", "Windy"};
        public string weatherCon;
        Random random = new Random();

        int temper;
        public Weather()
        {
           //WeatherTemp();
           //WeatherCondition();
        }

        //member methods
        public string WeatherCondition() 
        {
            int weatherindex = random.Next(weatherCondition.Count);
            string weatherDay = weatherCondition[weatherindex];
            UserInterface.DisplayWeather(weatherDay);
            weatherCon = weatherDay;
            return weatherCon;
        }
        public int WeatherTemp() 
        {
            Random random1 = new Random();
            int temp = random1.Next(50, 100);
            UserInterface.DisplayWeatherTemp(temp);
            temper = temp;
            return temper;
        }
    }
}
