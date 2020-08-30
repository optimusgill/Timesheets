
using System;
using System.ComponentModel.DataAnnotations;

namespace TimeSheetService.Models
{
    public class EmployeeData
    {
        [Key]
        public int EmployeeId { get; set; }
        public  Guid  EmployeeGuid{get;set;}
        public string EmployeeIdentifier{get;set;}
    }
}