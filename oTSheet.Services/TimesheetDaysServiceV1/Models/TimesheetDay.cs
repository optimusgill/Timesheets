using System.ComponentModel.DataAnnotations;

namespace TimeSheetService.Models
{
    public class TimesheetDay
    {
        [Key]
        public int Id{get;set;}
        public int TimeSheetID {get;set;}
        public EmployeeData Employee{get;set;}
        public System.DateTime Start {get;set;}
        public System.DateTime End {get;set;}
        public System.Collections.Generic.List<EventData> EventList {get;set;}
        public System.Collections.Generic.List<HrAmount> hrAmountsList {get;set;}
        public bool IsApproved{get;set;}
        public bool IsDeleted{get;set;}
        public string Description {get;set;}
        public EntryAudit EntryAudit{get;set;}
    }
}