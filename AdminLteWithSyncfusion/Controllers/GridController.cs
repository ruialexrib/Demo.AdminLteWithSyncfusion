using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AdminLteWithSyncfusion.Controllers
{
    public class GridController : Controller
    {
        // GET: Grid
        public ActionResult Index()
        {
            var countries = new List<GridCountryModel>();
            countries.Add(new GridCountryModel { Id = 1, Name = "Germany" });
            countries.Add(new GridCountryModel { Id = 2, Name = "Poland" });
            countries.Add(new GridCountryModel { Id = 3, Name = "Brazil" });
            countries.Add(new GridCountryModel { Id = 4, Name = "United States" });

            var models = new List<GridModel>();
            models.Add(new GridModel
            {
                Id = 1,
                Name = "Griffie Hensmans",
                Address = "40 Brown Terrace",
                CountryId = 1,
                Email = "gupward0@slideshare.net",
                BirthDate = DateTime.Now,
                IPAddress = "187.216.223.46"
            });
            models.Add(new GridModel
            {
                Id = 2,
                Name = "Monika Forrest",
                Address = "6240 Moose Parkway",
                CountryId = 2,
                Email = "mforrest1@cnet.com",
                BirthDate = DateTime.Now,
                IPAddress = "133.246.129.115"
            });
            models.Add(new GridModel
            {
                Id = 3,
                Name = "Rhianna Matschoss",
                Address = "22 Novick Alley",
                CountryId = 3,
                Email = "rmatschoss2@geocities.com",
                BirthDate = DateTime.Now,
                IPAddress = "140.135.85.12"
            });
            models.Add(new GridModel
            {
                Id = 4,
                Name = "Sebastiano Ralestone",
                Address = "34920 Monument Park",
                CountryId = 4,
                Email = "sralestone4@npr.org",
                BirthDate = DateTime.Now,
                IPAddress = "101.143.94.138"
            });
            models.Add(new GridModel
            {
                Id = 5,
                Name = "Tamma Francescone",
                Address = "1 Ronald Regan Way",
                CountryId = 1,
                Email = "tfrancescone7@netvibes.com",
                BirthDate = DateTime.Now,
                IPAddress = "192.37.172.39"
            });
            models.Add(new GridModel
            {
                Id = 6,
                Name = "Clarey Lampel",
                Address = "14 Grasskamp Avenue",
                CountryId = 2,
                Email = "clampel9@lulu.com",
                BirthDate = DateTime.Now,
                IPAddress = "22.177.222.227"
            });

            ViewBag.Models = models;
            ViewBag.Countries = countries;

            return View();
        }
    }

    public class GridModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string IPAddress { get; set; }
    }

    public class GridCountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}