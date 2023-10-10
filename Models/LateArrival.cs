using System.ComponentModel.DataAnnotations.Schema;

namespace Late_Staff.Models
{
    public class LateArrival
    {
        public int ID { get; set; }
        public int StaffMemberId { get; set; }

        [ForeignKey(nameof(StaffMemberId))]
        public StaffMember StaffMember { get; set; }

        public string Name { get; set; }
        public string StaffId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public bool Islate { get; set; }
    }
}
