using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SEP3_TIER1.Data
{
    public class PlaneDTO
    {
        [JsonProperty("callSign")]
        [Required]
        [StringLength(10, ErrorMessage = "Identifier too long (10 character limit).")]
        public string CallSign { get; set; }
        [JsonProperty("model")]
        [Required]
        [StringLength(15, ErrorMessage = "Identifier too long (15 character limit).")]
        public string Model { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).")]
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("startLocation")]
        [Required]
        [StringLength(20, ErrorMessage = "Identifier too long (16 character limit).")]
        public string StartLocation { get; set; }
        [JsonProperty("endLocation")]
        [Required]
        [StringLength(20, ErrorMessage = "Identifier too long (16 character limit).")]
        public string EndLocation { get; set; }
        [JsonProperty("delay")]
        public string Delay { get; set; }
        [JsonProperty("departureTime")]
        [Required]
        public string DepartureTime { get; set; }
        [JsonProperty("arrivalTime")]
        [Required]
        public string ArrivalTime { get; set; }
    }
}
