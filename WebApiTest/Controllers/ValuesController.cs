using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        MyDal myDal = new MyDal();
        // GET api/values
        [HttpGet]
        public IEnumerable<DateInterval> ReadIntervals(string from, string to)
        {
            var results = myDal.ReadIntervals(from, to).ToList();
            //results.Add(new DateInterval { Id = 1, From = DateTime.Now, To = DateTime.Now });
            return results;
        }
        
        // POST api/values
        [HttpPost]
        public void CreateInterval(string from, string to)
        {
                myDal.CreateInterval(to,from);
        }
    }
}
