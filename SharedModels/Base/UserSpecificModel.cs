using MongoDB.Bson.Serialization.Attributes;

namespace SartainStudios.SharedModels.Base;

public abstract class UserSpecificModel : NonuserSpecificModel
{
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? UserId { get; set; }
}