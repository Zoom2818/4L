using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4Lv2.Models;

public class Record
{
    [Key] public int Id { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public int? ServiceId { get; set; }
    [ForeignKey("ServiceId")] public Service? Service { get; set; }
    public int? UserId { get; set; }
    [ForeignKey("UserId")] public User? User { get; set; }
    public int? PayId { get; set; }
    [ForeignKey("PayId")] public Pay? Pay { get; set; }
    
}