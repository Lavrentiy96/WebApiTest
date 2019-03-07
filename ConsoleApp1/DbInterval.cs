namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbInterval : DbContext
    {
       
        public DbInterval()
            : base("name=DbInterval")
        {
        }
        public virtual DbSet<DateInterval> MyEntities { get; set; }
    }

    public class DateInterval
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}