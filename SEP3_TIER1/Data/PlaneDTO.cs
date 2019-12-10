using Newtonsoft.Json;
using System;

namespace SEP3_TIER1.Data
{
    public class PlaneDTO
    {
        [JsonProperty("callSign")]
        public string CallSign { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("startLocation")]
        public string StartLocation { get; set; }
        [JsonProperty("endLocation")]
        public string EndLocation { get; set; }
        [JsonProperty("delay")]
        public string Delay { get; set; }
        [JsonProperty("departureTime")]
        public string DepartureTime { get; set; }
        [JsonProperty("arrivalTime")]
        public string ArrivalTime { get; set; }


    }
}
