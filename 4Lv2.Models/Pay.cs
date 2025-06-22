using System.ComponentModel.DataAnnotations;

namespace _4Lv2.Models;

public class Pay
{
    [Key] public int Id { get; set; }
    public DateTime DateStart { get; set; }
    public bool IsCompleted { get; set; } = false;
    public string CardNumber { get; set; }
    public string  ValidityPeriod { get; set; }
    public string  CVV { get; set; }
}