using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models;

[Table("Results")]
public class Result
{
    [Key]
    public int ResultId { get; set; }

    public int EnrolmentId { get; set; }

    public TimeSpan? FinishTime { get; set; }

    public int? FinishingPosition { get; set; }

    [ForeignKey(nameof(EnrolmentId))]
    public Enrolment? Enrolment { get; set; }
}