using System.ComponentModel.DataAnnotations;

namespace Late_Staff.Models
{
    public class StaffMember
    {
        public int ID { get; set; }
        public string Name { get; set; }   
        public string? StaffId { get; set; }

    }
}
