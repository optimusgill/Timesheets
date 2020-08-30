using System.ComponentModel.DataAnnotations;

namespace TimeSheetService.Models
{
    public class EntryAudit
    {
        [Key]
        public int Id{get;set;}
        System.DateTime CreationDate {get;set;}
        string CreatedBy{get;set;}
         System.DateTime  LastModificationDate{get;set;}
         string ModifiedBy{get;set;}
    }
}