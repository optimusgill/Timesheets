using Microsoft.AspNetCore.Mvc;
using TimeSheetService.Models;
using TimesheetDaysService.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace TimesheetDaysService.Controller
{

    [Route("api/RegistrationTime")]
    [ApiController]
    public class RegistrationTimeSheetDayController:ControllerBase
    {
        private readonly TimeSheetDayContext _context;

        public RegistrationTimeSheetDayController(TimeSheetDayContext context)=> _context=context;   
         
         
         //POST api/RegistratrionTimeSheetDayController/{timesheet}
        [Route("InsertTimeSheet")]
        [HttpPost("timeSheet")]
        public ActionResult<TimesheetDay>PostTimeSheetDayItem(TimesheetDay timeSheet)
        {
            _context.TImeSheetDayItems.Add(timeSheet);
            try
            {
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return CreatedAtAction("GetAllTimeSheet",new TimesheetDay{TimeSheetID=timeSheet.TimeSheetID},timeSheet);
        }
        [Route("ModifyTimeSheet/")]
        [HttpPut("{TimeSheetID}")]
        public ActionResult PutTimesheetDay(int TimesheetDayId,TimesheetDay timeSheet)
        {
            if(TimesheetDayId!=timeSheet.TimeSheetID)
                return BadRequest();
            _context.Entry(timeSheet).State=EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }
    }
}