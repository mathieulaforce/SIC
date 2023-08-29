using LaMa.SIC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LaMa.SIC.Core.Controllers;

namespace LaMa.SIC.Web.Controllers
{
    public class TestController : SICController
    {
        public TestController()
        {
        }

        public IActionResult Index()
        {

            var person = new Person
            {
                Id = 1,
                Name = "Jean",
                Addresses = new List<Address>()
            };

            foreach (var i1 in Enumerable.Range(1, 5))
            {
                person.Addresses.Add(new Address
                {
                    Id = i1,
                    IsDomicile = i1 == 1,
                    City = $"City{i1}",
                    Country = $"Country{i1}",
                    PostalCode =$"PostalCode{i1}" ,
                    State =$"State{i1}" ,
                    Street =$"Street{i1}" ,
                    ZipCode =$"ZipCode{i1}"
                });
            }

            return SICView(person, "person");
        }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public bool IsDomicile { get; set; }
    }
}