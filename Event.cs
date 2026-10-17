using RaceDay.API.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models;

[Table("Events")]
public class Event
{
    [Key]
    public int EventId { get; set; }

    [Required, StringLength(150)]
    public string Name { get; set; } = string.Empty;

    [StringLength(2000)]
    public string Description { get; set; } = string.Empty;

    public DateTime EventDate { get; set; }

    [Required, StringLength(200)]
    public string Location { get; set; } = string.Empty;

    public decimal Distance { get; set; }

    public int EventTypeId { get; set; }

    public int OrganiserId { get; set; }

    [ForeignKey(nameof(EventTypeId))]
    public EventType? EventType { get; set; }

    [ForeignKey(nameof(OrganiserId))]
    public User? Organiser { get; set; }

    public ICollection<Category> Categories { get; set; }
        = new List<Category>();

    public ICollection<Enrolment> Enrolments { get; set; }
        = new List<Enrolment>();
}