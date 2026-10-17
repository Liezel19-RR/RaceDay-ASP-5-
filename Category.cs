using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models;

[Table("Categories")]
public class Category
{
    [Key]
    public int CategoryId { get; set; }

    public int EventId { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [ForeignKey(nameof(EventId))]
    public Event? Event { get; set; }

    public ICollection<Enrolment> Enrolments { get; set; }
        = new List<Enrolment>();
}