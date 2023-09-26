using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
    public class FavoriteController : Controller
    {
        FavoriteManager fm = new FavoriteManager(new EFFavoriteDal());
        // GET: Favorite
        public ActionResult Index()
        {
            var favVals = fm.GetList();
            return View(favVals);
        }

        [HttpGet]
		
        public ActionResult AddFav(int id)
        {
            var favVals = fm.GetList();
            var favorite = favVals.FirstOrDefault(x => x.MovieId == id && x.UserId == Convert.ToInt32(Session["UserId"]));
			if (favorite == null)
            {
                Favorite selFav = new Favorite();
                selFav.MovieId = id;
                selFav.UserId = Convert.ToInt32(Session["UserId"]);

                fm.FavoriteAddBL(selFav);

            }
            else
            {
                fm.FavoriteRemoveBL(favorite);
            }
			return RedirectToAction("Index", "Favorite");



		}
    }
}