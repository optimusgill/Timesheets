using Microsoft.EntityFrameworkCore;
using TimeSheetService.Models;

namespace TimesheetDaysService.Models
{
    public class TimeSheetDayContext:DbContext
    {
        public TimeSheetDayContext(DbContextOptions <TimeSheetDayContext> options):base(options)
        {}
        public DbSet<TimesheetDay>TImeSheetDayItems{get;set;}
        
    }
}