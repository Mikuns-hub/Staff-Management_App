using Late_Staff.Data;
using Microsoft.EntityFrameworkCore;

namespace Late_Staff.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MyApplicationDbContext>>()))
            {
                if (context.StaffMembers.Any())
                {
                    return;
                }
                context.StaffMembers.AddRange(
                new StaffMember
                {
                    // Id = 1001, 
                    Name = "Emeka Adio",
                    StaffId = "12345A"
                },

                new StaffMember
                {
                    //Id = 1001, 
                    Name = "Bola Ahmed",
                    StaffId = "12345B"
                },

                new StaffMember
                {
                    //Id = 1001, 
                    Name = "Wilson Johnson",
                    StaffId = "12345C"
                },

                new StaffMember
                {
                    //Id = 1001,
                    Name = "Ose Anetor",
                    StaffId = "12345D"

                });

                context.SaveChanges();
            }
        }
    }
}
