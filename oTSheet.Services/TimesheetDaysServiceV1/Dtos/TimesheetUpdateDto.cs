using TimeSheetService.Models;

namespace TimesheetDaysServiceV1.Dtos
{
    public class TimesheetUpdateDto
    {
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