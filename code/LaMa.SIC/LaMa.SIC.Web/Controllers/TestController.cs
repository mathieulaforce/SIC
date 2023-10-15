using System.ComponentModel.DataAnnotations;
using LaMa.SIC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LaMa.SIC.Core.Controllers;
using LaMa.SIC.Web.Features.Person;

namespace LaMa.SIC.Web.Controllers
{
    public class TestController : SICController
    {
        public TestController()
        {
        }
        [HttpGet]
        public IActionResult Index()
        {

            var person = new Person
            {
                Id = 1,
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
                    PostalCode = $"PostalCode{i1}",
                    State = $"State{i1}",
                    Street = $"Street{i1}",
                    ZipCode = $"ZipCode{i1}"
                });
            }

            return SICView(person, "person");
        }
        [HttpPost]
        public IActionResult Index(Person person)
        {
            if (ModelState.IsValid)
            {
                return SICView(person, "person");
            }

            return SICView(person, "person");
        }
    }


    public class Person
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string Name { get; set; }
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Date of birth")]
        public DateTimeOffset DateOfBirthOffset { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Addresses")]
        public List<Address> Addresses { get; set; }
    }

    public class Address
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        [Display(Name = "Is domicile")]
        public bool IsDomicile { get; set; }
    }
}