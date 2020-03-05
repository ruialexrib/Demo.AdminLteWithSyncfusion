using AdminLteWithSyncfusion.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdminLteWithSyncfusion.Services
{
    /// <summary>
    /// 
    /// </summary>
    public static class GridModelService
    {
        private static List<GridModel> _db = new List<GridModel>() { new GridModel
            {
                Id = 1,
                Name = "Griffie Hensmans",
                Address = "40 Brown Terrace",
                CountryId = 1,
                Email = "gupward0@slideshare.net",
                BirthDate = DateTime.Now,
                IPAddress = "187.216.223.46"
            },
            new GridModel
            {
                Id = 2,
                Name = "Monika Forrest",
                Address = "6240 Moose Parkway",
                CountryId = 2,
                Email = "mforrest1@cnet.com",
                BirthDate = DateTime.Now,
                IPAddress = "133.246.129.115"
            },
            new GridModel
            {
                Id = 3,
                Name = "Rhianna Matschoss",
                Address = "22 Novick Alley",
                CountryId = 3,
                Email = "rmatschoss2@geocities.com",
                BirthDate = DateTime.Now,
                IPAddress = "140.135.85.12"
            },
            new GridModel
            {
                Id = 4,
                Name = "Sebastiano Ralestone",
                Address = "34920 Monument Park",
                CountryId = 4,
                Email = "sralestone4@npr.org",
                BirthDate = DateTime.Now,
                IPAddress = "101.143.94.138"
            },
            new GridModel
            {
                Id = 5,
                Name = "Tamma Francescone",
                Address = "1 Ronald Regan Way",
                CountryId = 1,
                Email = "tfrancescone7@netvibes.com",
                BirthDate = DateTime.Now,
                IPAddress = "192.37.172.39"
            },
            new GridModel
            {
                Id = 6,
                Name = "Clarey Lampel",
                Address = "14 Grasskamp Avenue",
                CountryId = 2,
                Email = "clampel9@lulu.com",
                BirthDate = DateTime.Now,
                IPAddress = "22.177.222.227"
            }
        };

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public static List<GridModel> Get()
        {
            return _db;
        }

        /// <summary>
        /// Adds the specified gridmodel.
        /// </summary>
        /// <param name="gridmodel">The gridmodel.</param>
        /// <returns></returns>
        public static GridModel Add(GridModel gridmodel)
        {
            var count = _db.Count;
            gridmodel.Id = count + 1;
            _db.Add(gridmodel);
            return gridmodel;
        }

        /// <summary>
        /// Modifies the specified gridmodel.
        /// </summary>
        /// <param name="gridmodel">The gridmodel.</param>
        /// <returns></returns>
        public static GridModel Modify(GridModel gridmodel)
        {
            var record = _db.Where(x => x.Id == gridmodel.Id).FirstOrDefault();
            var indexOf = _db.IndexOf(record);
            _db[indexOf] = gridmodel;
            return gridmodel;
        }

        /// <summary>
        /// Removes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static GridModel Remove(int id)
        {
            var record = _db.Where(x => x.Id == id).FirstOrDefault();
            _db.Remove(record);
            return record;
        }
    }
}