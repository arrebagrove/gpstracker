﻿namespace ZHAW.GpsTracker.Web.Hubs
{
    public class Location
    {
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double Speed { get; set; }
    }
}