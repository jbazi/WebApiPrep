using PersonRegistryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PersonRegistryApp.Controllers
{
    public class PersonRegistryController : ApiController
    {
        List<PersonRegistry> pRegistries = new List<PersonRegistry>()
        {
            new PersonRegistry {Id = 101, FirstName="John", LastName="Mutabazi", Gender='M', Occupation="Software Consultant", StreetAddress="123 Taylor Rd", CityAddress="Lawrenceville", State="GA", ZipCode="30045", RecordedTime = DateTime.Now },
            new PersonRegistry {Id = 102, FirstName="Jeff", LastName="Summers", Gender='M', Occupation="CEO at Startup", StreetAddress="123 Morris Rd", CityAddress="Alpharetta", State="GA", ZipCode="30005", RecordedTime = DateTime.Now },
            new PersonRegistry {Id = 103, FirstName="Meghan", LastName="Smith", Gender='F', Occupation="Business Analyst", StreetAddress="12 Jackson Street", CityAddress="Duluth", State="GA", ZipCode="30096", RecordedTime = DateTime.Now },
            new PersonRegistry {Id = 104, FirstName="Jackson", LastName="Woodson", Gender='M', Occupation="EVP Technology at Startup", StreetAddress="18AB Atlanta NW Rd", CityAddress="Atlanta", State="GA", ZipCode="30105", RecordedTime = DateTime.Now }
        };
        // GET: api/PersonRegistry
        public IEnumerable<PersonRegistry> GetAllPersonRegistry()
        {
            return pRegistries;
        }

        // GET: api/PersonRegistry/5
        public IHttpActionResult GetPersonRegistry(int id)
        {
            var pRegistry = pRegistries.FirstOrDefault(p => p.Id == id);
            if (pRegistry == null)
                return NotFound();

            return Ok(pRegistry);
        }

        // POST: api/PersonRegistry
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/PersonRegistry/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PersonRegistry/5
        public void Delete(int id)
        {
        }
    }
}
