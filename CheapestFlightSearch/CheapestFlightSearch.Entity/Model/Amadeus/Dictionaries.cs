﻿using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class Dictionaries
    {
        [JsonPropertyName("locations")]
        public Locations Locations { get; set; }

        [JsonPropertyName("aircraft")]
        public Aircraft Aircraft { get; set; }

        [JsonPropertyName("currencies")]
        public Currencies Currencies { get; set; }

        [JsonPropertyName("carriers")]
        public Carriers Carriers { get; set; }
    }
}
