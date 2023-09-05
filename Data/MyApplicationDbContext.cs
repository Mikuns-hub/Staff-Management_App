using Late_Staff.Models;
using Microsoft.EntityFrameworkCore;

namespace Late_Staff.Data
{
    public class MyApplicationDbContext: DbContext
    {
        public MyApplicationDbContext(DbContextOptions<MyApplicationDbContext>options) : base(options)
        {
                
        }
        public DbSet<StaffMember> StaffMembers { get; set; } 

        public DbSet<LateArrival> LateArrivals { get; set;}

    }
}
