using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace SartainStudios.SharedModels.Base;

public abstract class NonuserSpecificModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [Required]
    public DateTime SystemStart { get; set; } = DateTime.UtcNow;
    [Required]
    public DateTime SystemEnd { get; set; } = DateTime.MaxValue;
}