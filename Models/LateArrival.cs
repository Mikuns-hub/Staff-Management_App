using System.ComponentModel.DataAnnotations.Schema;

namespace Late_Staff.Models
{
    public class LateArrival
    {
        public int Id { get; set; }
        public int StaffMemberId { get; set; }

        [ForeignKey(nameof(StaffMemberId))]
        public StaffMember StaffMember { get; set; }

        public string Name { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
