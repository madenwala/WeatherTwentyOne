using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace WeatherTwentyOne.Core.Models
{
    public abstract class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}