using System.Dynamic;

namespace MFEndpoint.Domain;

public class ObservationElement : BaseEntity<int>
{
    public string? FieldName { get; set; }
    public string? StandardName { get; set; }
    public string? LongName { get; set; }

    public string? Axis { get; set; }
    public string? Unit { get; set; }

    public string? Comment { get; set; }
}
