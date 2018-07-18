using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;

namespace linkhub.Areas.Common.Controllers
{
    public class BrowseURLController : Controller
    {
		private UrlBs objBs;
		public BrowseURLController()
		{
			objBs = new UrlBs();
		}

        // GET: Common/BrowseURL
        public ActionResult Index(string SortOrder, string SortBy)
        {
			ViewBag.SortOrder = SortOrder;
			ViewBag.SortBy = SortBy;
			var urls = objBs.GetAll().Where(x => x.IsApproved == "A");
			switch (SortOrder)
			{
				case "Asc":
					urls = urls.OrderBy(x => x.UrlTitle).ToList();
					break;
				case "Desc":
					urls = urls.OrderByDescending(x => x.UrlTitle).ToList();
					break;
				default:
					break;
			}
			return View(urls);
        }
    }
}