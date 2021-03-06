using SartainStudios.SharedModels.Base;
using System.ComponentModel.DataAnnotations;

namespace SartainStudios.SharedModels.User;

public class UserModel : NonuserSpecificModel
{
    [Required]
    [MinLength(3)]
    public string Username { get; set; }

    [Required]
    [MinLength(8)]
    public string Password { get; set; }

    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [MaxLength(30)]
    public string? FirstName { get; set; }

    [MaxLength(30)]
    public string? LastName { get; set; }

    public string? ProfilePhoto { get; set; }

    public string[]? Roles { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime? Created { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime[]? AuthenticationHistory { get; set; }

    public string[]? ApplicationsUsed { get; set; }
}