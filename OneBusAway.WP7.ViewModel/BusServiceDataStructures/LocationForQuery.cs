﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Device.Location;
using System.Runtime.Serialization;
using Microsoft.Phone.Controls.Maps;

namespace OneBusAway.WP7.ViewModel.BusServiceDataStructures
{
    public enum Confidence : int
    { 
        High = 10,
        Medium = 7, 
        Low = 4,
        Unknown = 0
    };

    [DataContract]
    public class LocationForQuery
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public GeoCoordinate location { get; set; }
        [DataMember]
        public Confidence confidence { get; set; }
        [DataMember]
        public LocationRect boundingBox { get; set; }
    }
}
