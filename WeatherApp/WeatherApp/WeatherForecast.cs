﻿using System.Collections.Generic;

namespace WeatherApp
{
    public class WeatherForecast
    {
        public city city { get; set; }
        public List<list> list { get; set; }
    }

    public class main
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
    }

    public class weather
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class wind
    {
        public double speed { get; set; }
    }

    public class city
    {
        public string name { get; set; }
    }

    public class daytime
    {
        public double dt { get; set; }
    }

    public class list
    {
        public double dt { get; set; }
        public wind wind { get; set; }
        public main main { get; set; }
        public List<weather> weather { get; set; }
    }
}