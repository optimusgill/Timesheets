using System.ComponentModel.DataAnnotations;

namespace TimeSheetService.Models
{
    public class WarningError
    {
        [Key]
        System.Guid ErrorID {get;set;}
        string UserData{get;set;}
        System.DateTime OccurredDateTime {get;set;}
        string Context{get;set;}
        string Description{get;set;}

    }
}