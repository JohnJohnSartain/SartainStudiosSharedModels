using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SartainStudios.SharedModels.Users;

public abstract class UserSpecificEntityBase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("userid")]
    public string? UserId { get; set; }
}