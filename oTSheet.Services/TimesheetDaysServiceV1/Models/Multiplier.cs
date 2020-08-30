using System.ComponentModel.DataAnnotations;

namespace TimeSheetService.Models
{
    public class Multiplier
    {
        [Key]
        int MultiplierID{get;set;}
        float Multinumber{get;set;}
        bool IsHourly{get;set;}
        string Description{get;set;}
    }
}