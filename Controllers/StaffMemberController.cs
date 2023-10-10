using System.Drawing.Text;
using Late_Staff.Data;
using Late_Staff.Dto;
using Late_Staff.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [HttpPost]
        public IActionResult LogArrivalTime(LogArrivalDto logArrival)
        {
            var staff = _context.StaffMembers.FirstOrDefault(x => x.StaffId == logArrival.StaffId);

            if (staff != null)
            {
                DateTime lastInputTime = DateTime.Now;

                var hasStaffCheckedIn = _context.LateArrivals.Where(x => x.StaffId == logArrival.StaffId && x.ArrivalTime.Date == lastInputTime.Date);

                if (hasStaffCheckedIn.Any())
                {
                    ModelState.AddModelError("StaffId", "Staff has already logged in today. ");
                    return View("LogArrivalTime");
                }

                DateTime arrivalTime = DateTime.Now;    

                DateTime officialOpeningTime = DateTime.Today.AddHours(9);
                
                int result = DateTime.Compare(arrivalTime, officialOpeningTime);

                    var LateArrival = new LateArrival
                    {
                        Name = staff.Name,
                        StaffId = logArrival.StaffId,
                        ArrivalTime = arrivalTime,
                        StaffMemberId = staff.ID
                    };
                
                if (result > 0)
                {
                    LateArrival.Islate = true;
                }
                _context.LateArrivals.Add(LateArrival);
                _context.SaveChanges();

                return View();
            }
            return RedirectToAction("LogArrivalTime");


        }

        public IActionResult CheckLateStaffs(DateTime? selectedDate)
        {
            var lateArrivals = _context.LateArrivals.Where(x => selectedDate == null || (x.ArrivalTime) == selectedDate).OrderByDescending(x => x.ArrivalTime).ToList();


            return View("CheckLateStaffs", lateArrivals);
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
