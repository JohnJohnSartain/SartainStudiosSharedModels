﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SartainStudios.SharedModels.Users;

public abstract class NonUserSpecificEntityBase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
}