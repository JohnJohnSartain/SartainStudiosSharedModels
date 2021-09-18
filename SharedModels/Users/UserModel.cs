using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace SartainStudios.SharedModels.Users;

public class UserModel : NonUserSpecificEntityBase
{
    [BsonElement("username")]
    [Required]
    [MinLength(3)]
    public string Username { get; set; }

    [BsonElement("password")]
    [Required]
    [MinLength(8)]
    public string Password { get; set; }

    [BsonElement("email")]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [BsonElement("firstname")]
    [MaxLength(30)]
    public string FirstName { get; set; }

    [BsonElement("lastname")]
    [MaxLength(30)]
    public string Lastname { get; set; }

    [BsonElement("profilephoto")]
    public string ProfilePhoto { get; set; }

    [BsonElement("roles")]
    public string[] Roles { get; set; }

    [BsonElement("created")]
    [DataType(DataType.DateTime)]
    public DateTime Created { get; set; }

    [BsonElement("authenticationhistory")]
    [DataType(DataType.DateTime)]
    public DateTime[] AuthenticationHistory { get; set; }

    [BsonElement("applicationsused")]
    public string[] ApplicationsUsed { get; set; }
}