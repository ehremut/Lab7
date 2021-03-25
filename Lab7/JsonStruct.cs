#nullable enable
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Lab7
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Address
    {
        [JsonProperty("house_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? HouseNumber { get; set; }

        [JsonProperty("road", NullValueHandling = NullValueHandling.Ignore)]
        public string? Road { get; set; }

        [JsonProperty("suburb", NullValueHandling = NullValueHandling.Ignore)]
        public string? Suburb { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string? City { get; set; }

        [JsonProperty("county", NullValueHandling = NullValueHandling.Ignore)]
        public string? County { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string? State { get; set; }

        [JsonProperty("postcode", NullValueHandling = NullValueHandling.Ignore)]
        public string? Postcode { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string? Country { get; set; }

        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? CountryCode { get; set; }
    }

    public class Properties
    {
        [JsonProperty("place_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? PlaceId { get; set; }

        [JsonProperty("osm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string? OsmType { get; set; }

        [JsonProperty("osm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? OsmId { get; set; }

        [JsonProperty("place_rank", NullValueHandling = NullValueHandling.Ignore)]
        public string? PlaceRank { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("importance", NullValueHandling = NullValueHandling.Ignore)]
        public long? Importance { get; set; }

        [JsonProperty("addresstype", NullValueHandling = NullValueHandling.Ignore)]
        public string? Addresstype { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? DisplayName { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Address? Address { get; set; }
    }

    public class Geometry
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public List<double>? Coordinates { get; set; }
    }

    public class Feature
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Properties? Properties { get; set; }

        [JsonProperty("bbox", NullValueHandling = NullValueHandling.Ignore)]
        public List<double>? Bbox { get; set; }

        [JsonProperty("geometry", NullValueHandling = NullValueHandling.Ignore)]
        public Geometry? Geometry { get; set; }
    }

    public class Root
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("licence", NullValueHandling = NullValueHandling.Ignore)]
        public string? Licence { get; set; }

        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<Feature>? Features { get; set; }
    }


}