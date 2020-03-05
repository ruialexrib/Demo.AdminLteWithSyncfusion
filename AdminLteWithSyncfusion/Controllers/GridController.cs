using AdminLteWithSyncfusion.Controllers.Models;
using AdminLteWithSyncfusion.Services;
using Syncfusion.EJ2.Base;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AdminLteWithSyncfusion.Controllers
{
    /// <summary></summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class GridController : Controller
    {
        // GET: Grid
        /// <summary>Indexes this instance.</summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var countries = new List<GridCountryModel>();
            countries.Add(new GridCountryModel { Id = 1, Name = "Germany" });
            countries.Add(new GridCountryModel { Id = 2, Name = "Poland" });
            countries.Add(new GridCountryModel { Id = 3, Name = "Brazil" });
            countries.Add(new GridCountryModel { Id = 4, Name = "United States" });

            ViewBag.Countries = countries;

            return View();
        }

        /// <summary>
        /// URLs the datasource.
        /// </summary>
        /// <param name="dm">The dm.</param>
        /// <returns></returns>
        public ActionResult UrlDatasource(DataManagerRequest dm)
        {
            IEnumerable DataSource = GridModelService.Get();
            DataOperations operation = new DataOperations();

            if (dm.Search != null && dm.Search.Count > 0)
            {
                DataSource = operation.PerformSearching(DataSource, dm.Search);  //Search
            }

            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {
                DataSource = operation.PerformSorting(DataSource, dm.Sorted);
            }

            if (dm.Where != null && dm.Where.Count > 0) //Filtering
            {
                DataSource = operation.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);
            }

            int count = DataSource.Cast<GridModel>().Count();

            if (dm.Skip != 0)
            {
                DataSource = operation.PerformSkip(DataSource, dm.Skip);   //Paging
            }
            if (dm.Take != 0)
            {
                DataSource = operation.PerformTake(DataSource, dm.Take);
            }
            return dm.RequiresCounts ? Json(new { result = DataSource, count = count }) : Json(DataSource);
        }

        /// <summary>
        /// Inserts the specified object.
        /// </summary>
        /// <param name="Object">The object.</param>
        /// <returns></returns>
        public ActionResult Insert(CRUDModel<GridModel> Object)
        {
            var record = Object.Value;
            GridModelService.Add(record);
            return Json(record);
        }

        /// <summary>Updates the specified object.</summary>
        /// <param name="Object">The object.</param>
        /// <returns></returns>
        public ActionResult Update(CRUDModel<GridModel> Object)
        {
            var record = Object.Value;
            GridModelService.Modify(record);
            return Json(record);
        }

        /// <summary>
        /// Deletes the specified object.
        /// </summary>
        /// <param name="Object">The object.</param>
        /// <returns></returns>
        public ActionResult Delete(CRUDModel<GridModel> Object)
        {
            int id = (int)Object.Key;
            GridModelService.Remove (id);
            return Json(Object);
        }

    }
}