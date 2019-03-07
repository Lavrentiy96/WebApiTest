namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Runtime.Serialization;

    public class DbDate : DbContext
    {
         public DbDate()
            : base("name=DbDate")
        {
        }

        public virtual DbSet<DateInterval> DateIntervals { get; set; }
    }

    [DataContract]
    public class DateInterval
    {
        public int Id { get; set; }
        [DataMember]
        public DateTime From { get; set; }
        [DataMember]

        public DateTime To { get; set; }
    }
}