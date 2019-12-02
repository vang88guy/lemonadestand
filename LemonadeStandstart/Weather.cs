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
        Random random = new Random();

        int temper;
        public Weather()
        {
            temper = WeatherTemp();    
        }

        //member methods
        public void WeatherCondition() 
        {
            int weatherindex = random.Next(weatherCondition.Count);
            string weatherDay = weatherCondition[weatherindex];
            UserInterface.DisplayWeather(weatherDay);
        }
        public int WeatherTemp() 
        {
            Random random1 = new Random();
            int temp = random1.Next(50, 100);
            UserInterface.DisplayWeatherTemp(temp);
            
            return temp;
        }
    }
}
