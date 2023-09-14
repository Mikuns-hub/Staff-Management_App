using Late_Staff.Data;
using Late_Staff.Models;
using Microsoft.AspNetCore.Mvc;

namespace Late_Staff.Controllers
{
    public class StaffMemberController : Controller
    {
         private readonly MyApplicationDbContext _context;

        public StaffMemberController(MyApplicationDbContext context)
        {
            _context = context;
        }

    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogArrivalTime()
        {
            return View();
        }

        public IActionResult CheckLateStaffs()
        {
            return View();
        }

        //Get Staff by Id   
        /*  public IActionResult LoginPage(string id)
          {
              var staffMember = _context.StaffMembers.FirstOrDefault(s => s.StaffId == id);

              if (staffMember == null)
              {
                  return NotFound();
              }

              bool isLate = IsStaffLate(staffMember.ArrivalTime);

              ViewBag.Staff = staffMember;
              ViewBag.IsLate = isLate;

              if (isLate)
              {
                  RecordLateArrival(staffMember);

              }
              return View(staffMember);
          }

          private bool IsStaffLate(DateTime arrivalTime)
          {
              DateTime officialOpeningTime = DateTime.Today.AddHours(9);
              return arrivalTime > officialOpeningTime;
          }
          private void RecordLateArrival(StaffMember staffMember)
          {
              var lateArrival = new LateArrival
              {
                  StaffId = staffMember.StaffId,
                  ArrivalTime = staffMember.ArrivalTime
              };

              _context.LateArrivals.Add(lateArrival);

              _context.SaveChanges();
          }*/



    }
}
