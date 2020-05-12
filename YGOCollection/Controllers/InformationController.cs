using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YGOCollection.library.Model;
using YGOCollection.library.ViewModel.ApiVviewModel;

namespace YGOCollection.Controllers
{
   
    public class InformationController : Controller
    {
        private YGOCardInfoEntities db = new YGOCardInfoEntities();
        // GET: Information
        public ActionResult Index()
        {
            var result = db.Information.ToList();
            return View(result);
        }
       

    }
}