using MFEndpoint.Domain;

class WeatherStation : BaseEntity<int>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public GeoLocation? Location { get; set; }

    public Dictionary<string, object> AdditionalProperties { get; set; } =
        new Dictionary<string, object> { };
}
