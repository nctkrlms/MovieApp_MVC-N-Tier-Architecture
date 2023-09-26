using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
	public class MovieController : Controller
	{
		MovieManager mm = new MovieManager(new EFMovieDal());
		CategoryManager cm = new CategoryManager(new EFCategoryDal());
		

		public ActionResult Index()
		{
			var movieValues = mm.GetList();
			return View(movieValues);
		}
		[HttpGet]
		public ActionResult AddMovie()
		{
			List<SelectListItem> valueCategory = (from x in cm.GetList()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryId.ToString()
												  }).ToList();
			ViewBag.vlc = valueCategory;
												  
			return View();
		}
		[HttpPost]
		public ActionResult AddMovie(Movie movie)
		{
			mm.MovieAddBL(movie);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult MovieDetail(int id)
		{
			var movVal = mm.GetById(id);
			return View(movVal);
		}
	}
}