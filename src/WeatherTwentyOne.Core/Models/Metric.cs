namespace WeatherTwentyOne.Core.Models
{
    public class Metric : BaseModel
    {
        public string Icon { get;set;}
        public string Title { get; set; }
        public string WeatherStation { get; set; }
        public string Value { get; set; }
    }
}