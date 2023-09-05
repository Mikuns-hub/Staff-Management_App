namespace Late_Staff.Models
{
    public class LateArrival
    {
        public int Id { get; set; }
        public string StaffId { get; set; }

        public string Name { get; set; }
        public DateTime ArrivalTime { get; set; }

        public StaffMember StaffMember { get; set; }

    }
}
