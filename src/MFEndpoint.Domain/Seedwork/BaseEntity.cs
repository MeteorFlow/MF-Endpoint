using System.ComponentModel.DataAnnotations;

namespace MFEndpoint.Domain;

public abstract class BaseEntity<T>
    where T : IEquatable<T>
{
    [Key]
    public virtual T Id { get; set; }
}
