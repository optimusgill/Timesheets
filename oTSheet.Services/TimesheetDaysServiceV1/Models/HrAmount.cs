using System.ComponentModel.DataAnnotations;

namespace TimeSheetService.Models
{
    public class HrAmount
    {
        public float Hours{get;set;}
        [Key]
        public int MultiplierID{get;set;}
    }
}