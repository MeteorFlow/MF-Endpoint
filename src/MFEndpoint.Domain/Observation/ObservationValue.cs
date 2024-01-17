using System.ComponentModel.DataAnnotations.Schema;
using MFEndpoint.Domain;

class ObservationValue : BaseEntity<Guid>
{
    public byte Value { get; set; }
    public DateTime RecordTime { get; set; }

    [ForeignKey("WeatherStation")]
    public int WeatherStationId { get; set; }

    [ForeignKey("ObservationElement")]
    public int ObservationElementId { get; set; }
}
