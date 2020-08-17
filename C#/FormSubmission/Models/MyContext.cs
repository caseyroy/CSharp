using Microsoft.EntityFrameworkCore;

namespace FormSubmission.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }
    }
}