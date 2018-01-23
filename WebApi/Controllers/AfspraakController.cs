using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.EF;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AfspraakController : ApiController
    {
        private readonly AfspraakContext _context;

        public AfspraakController()
        {
            _context = new AfspraakContext();
        }
        // GET api/<controller>
        [AcceptVerbs("GET")]
        [HttpGet]
        public IEnumerable<Afspraak> Get([FromUri]DateTime datet)
        {
            //string datum = datet.ToString();
            //var year = int.Parse(datum.Substring(0, 4));
            //var month = int.Parse(datum.Substring(4, 2));
            //var day = int.Parse(datum.Substring(6, 2));

            //var date = new DateTime(year, month, day);

            var test = _context.Afspraken.Where(a => a.AfspraakDatum >= datet).ToList();
            return test;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Afspraak afspraak)
        {
            _context.Afspraken.Add(afspraak);
            _context.SaveChanges();
        }
    }
}