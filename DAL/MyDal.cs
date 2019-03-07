using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyDal
    {
        private readonly DbDate db = new DbDate();

        public IEnumerable<DateInterval> ReadIntervals(string from, string to)
        {
            var dateStart = Convert.ToDateTime(from);
            var dateEnd = Convert.ToDateTime(to);
            
            IEnumerable<DateInterval> results = db.DateIntervals.Where(a=>
            (a.From>=dateStart && a.From<=dateEnd) 
            ||
            (a.To >= dateStart && a.To <= dateEnd));
            return results.ToArray();
        }
        public void CreateInterval(string from, string to)
        {
            db.DateIntervals.Add(new DateInterval
            {
                From = Convert.ToDateTime(from),
                To = Convert.ToDateTime(to)
            });
            db.SaveChanges();
        }
    }
}

