using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimesheetDaysService.Models;
using TimeSheetService.Models;

namespace RetriveTimesheetDaysService.Controller
{

     [Route("api/RetriveTimesheetDaysService")]
    [ApiController]
    public class RetriveTimesheetDaysService:ControllerBase
    {
        private readonly TimeSheetDayContext _context;

        public RetriveTimesheetDaysService(TimeSheetDayContext context )=>_context=context;
        
        //api/TimeSheetDayController all timesheet
        [HttpGet]
        public ActionResult <IEnumerable<TimesheetDay>> GetAllTimeSheet()
        {
            return _context.TImeSheetDayItems;

        }

        //api/TimeSheetDayController/list<Employee>Employees
        [HttpGet("{List<EmployeeData>Employees}")]
        public ActionResult<IEnumerable<TimesheetDay>>GetTimeSheetDayByEmployees(List<EmployeeData>Employees)
        {
            var result =(from first in _context.TImeSheetDayItems
                        where Employees.All(emp => first.Employee.EmployeeGuid.Equals(emp.EmployeeGuid)) //== emp.EmployeeGuid)
                        select first );         
            if(result==null)
                return NotFound();
            return result.ToList();
        }

        //api/TimeSheetDayController/Employee
        [HttpGet("{Employee}")]
        public ActionResult<IEnumerable<TimesheetDay>>GetTImeSheetDayByEmployee(EmployeeData employee)
        {
            var result = from x in _context.TImeSheetDayItems 
                         where x.Employee.EmployeeGuid==employee.EmployeeGuid 
                         select x;
            if(result==null)
                return NotFound();
            return Ok(result.ToList());
        }


        //api/TimeSheetDayController/list<EventData>Events
        [HttpGet("{List<EventData>Eventes}")]
        public ActionResult<IEnumerable<TimesheetDay>>GetTimeSheetDayByEvent(List<EventData>Events)
        {
            List<TimesheetDay> listTimeSheetDays =_context.TImeSheetDayItems.ToList();
            var result = from first in listTimeSheetDays
                where Events.All(e=>first.EventList.Contains(e))select first;
             if (result==null)   
                return NotFound();
            return Ok(result.ToList());
        }

        //api/TimeSheetDayController/{StartDate}/{EndDate}/{showSoftDeleted}
        [HttpGet("{StartDate}/{EndDate}/{showSoftDeleted}")]
        public ActionResult <IEnumerable<TimesheetDay>>GetTimeSheetDaysByDates(DateTime? Start =null, DateTime? End=null, bool showSoftDeleted = false)
        {
           // List<TimesheetDay>listTimeSheetDays= _context.TImeSheetDayItems.ToList();
            var result =( from x in _context.TImeSheetDayItems
            where x.Start >= Start && x.End<= End && x.IsDeleted == showSoftDeleted
            select x);
            if(result==null)
                return NotFound();
            return Ok(result.ToList());
        }
    }
}