using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
	public class CategoryController : Controller
	{
		// GET: Category
		CategoryManager cm = new CategoryManager(new EFCategoryDal());
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult GetCategoryList()
		{
			var categoryValues = cm.GetList();
			return View(categoryValues);
		}
		[HttpGet]
		public ActionResult AddCategory()
		{
			return View(); 
		}
		[HttpPost]
		public ActionResult AddCategory(Category category)
		{
			//cm.CategoryAddBL(category);
			CategoryValidation categoryValidation = new CategoryValidation();
			ValidationResult result = categoryValidation.Validate(category);
			if(result.IsValid)
			{
				cm.CategoryAddBL(category);
				return RedirectToAction("GetCategoryList");
			}
			else
			{
				foreach(var item in result.Errors)
				{

					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

				}
			}
			return View();
			

		}
	}
}