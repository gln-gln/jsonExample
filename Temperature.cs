
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace jsonDeserialize
{

    public class Temperatures
    {
        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("TemperatureCelsius")]
        public long TemperatureCelsius { get; set; }

        [JsonProperty("Summary")]
        public string Summary { get; set; }

        [JsonProperty("DatesAvailable")]
        public DateTimeOffset[] DatesAvailable { get; set; }

        [JsonProperty("TemperatureRanges")]
        public TemperatureRanges TemperatureRanges { get; set; }

        [JsonProperty("SummaryWords")]
        public string[] SummaryWords { get; set; }

        [JsonProperty("dummyValue")]
        public string[] dummyValue { get; set; }
    }

    public partial class TemperatureRanges
    {
        [JsonProperty("Cold")]
        public Cold Cold { get; set; }

        [JsonProperty("Hot")]
        public Cold Hot { get; set; }
    }

    public partial class Cold
    {
        [JsonProperty("High")]
        public long High { get; set; }

        [JsonProperty("Low")]
        public long Low { get; set; }
    }



}
