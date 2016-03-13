using System.Data.Entity;

namespace DevExpress.MailClient.EF
{
    public class MailContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}