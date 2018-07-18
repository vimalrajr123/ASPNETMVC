using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace linkhub.Areas.Admin.Controllers
{
    public class ApproveURLsController : Controller
    {
        // GET: Admin/ApprovedURLs
        public ActionResult Index()
        {
            return View();
        }
    }
}