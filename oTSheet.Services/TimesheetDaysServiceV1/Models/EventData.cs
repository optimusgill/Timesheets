using System.ComponentModel.DataAnnotations;

namespace TimeSheetService.Models
{
    public class EventData
    {
        [Key]
        public int id {get;set;}
        public int EventId{get;set;}
        public string Description {get;set;}
        public System.DateTime Start {get;set;}
        public System.DateTime End{get;set;}
    }
}