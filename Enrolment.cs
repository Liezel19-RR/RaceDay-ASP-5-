using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models;

[Table("Enrolments")]
public class Enrolment
{
    [Key]
    public int EnrolmentId { get; set; }

    public int UserId { get; set; }

    public int EventId { get; set; }

    public int CategoryId { get; set; }

    public DateTime EnrolmentDate { get; set; }
        = DateTime.UtcNow;

    [Required, StringLength(30)]
    public string Status { get; set; } = "Confirmed";

    [ForeignKey(nameof(UserId))]
    public User? Participant { get; set; }

    [ForeignKey(nameof(EventId))]
    public Event? Event { get; set; }

    [ForeignKey(nameof(CategoryId))]
    public Category? Category { get; set; }

    public Result? Result { get; set; }
}