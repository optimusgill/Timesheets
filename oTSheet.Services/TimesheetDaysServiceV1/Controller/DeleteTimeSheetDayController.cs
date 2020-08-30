using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TimesheetDaysService.Models;
using TimeSheetService.Models;

namespace TimesheetDaysService.Controller
{
    [Route("api/DeleteTimeSheetDayController")]
    [ApiController]
    
    public class DeleteTimeSheetDayController:ControllerBase
    {
        private readonly TimeSheetDayContext _context;

        public DeleteTimeSheetDayController(TimeSheetDayContext context)=>_context = context ;
        [Route("TimeSheetDay/remove/{TimesheetId}")]
        //DELETE api/Timessheedaycontroller/{TImeSheetDayId}
        [HttpDelete("{TimesheetId}")]
        public ActionResult<TimesheetDay>DeleteTimesheet(int timesheetId)
        {
            TimesheetDay timeSheetItem =   _context.TImeSheetDayItems.First(TimesheetDay=>TimesheetDay.TimeSheetID==timesheetId); 
    
            if(timeSheetItem!=null) 
                return NotFound();
           
            _context.TImeSheetDayItems.Remove(timeSheetItem);
            _context.SaveChanges();
            return timeSheetItem;


        }
    }
}