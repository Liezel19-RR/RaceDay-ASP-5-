using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models;

[Table("Users")]
public class User
{
    [Key]
    public int UserId { get; set; }

    [Required, StringLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required, StringLength(100)]
    public string LastName { get; set; } = string.Empty;

    [Required, EmailAddress, StringLength(256)]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    [Required, StringLength(20)]
    public string Role { get; set; } = "Participant";

    public ICollection<Event> OrganisedEvents { get; set; }
        = new List<Event>();

    public ICollection<Enrolment> Enrolments { get; set; }
        = new List<Enrolment>();
}