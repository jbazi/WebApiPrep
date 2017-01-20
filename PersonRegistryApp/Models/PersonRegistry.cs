using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonRegistryApp.Models
{
    public class PersonRegistry
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public char Gender { get; set; }
        public string StreetAddress { get; set; }
        public string CityAddress { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime RecordedTime { get; set; }
    }
}