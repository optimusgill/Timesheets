using System.ComponentModel.DataAnnotations;

namespace TimeSheetService.Models
{
    public class FatalError
    {
        [Key]
        System.Guid ErrorID{get;set;}
        string UserData{get;set;}
        System.DateTime OccurredDateTime {get;set;}
        string Context{get;set;}
        string BackException{get;set;}
        string FrontException{get;set;}
        string GenericErrorDescription{get;set;}

    }
}