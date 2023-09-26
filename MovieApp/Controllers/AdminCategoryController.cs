using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
	public class AdminCategoryController : Controller
	{
		CategoryManager cm = new CategoryManager(new EFCategoryDal());
		public ActionResult Index()
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
			CategoryValidation categoryValidation = new CategoryValidation();
			ValidationResult validationResult = categoryValidation.Validate(category);
			if (validationResult.IsValid)
			{
				cm.CategoryAddBL(category);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in validationResult.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
		public ActionResult DeleteCategory(int id)
		{
			var categoryValue = cm.GetById(id);
			cm.CategoryRemoveBL(categoryValue);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult EditCategory(int id)
		{
			var categoryValue = cm.GetById(id);
			return View(categoryValue);
		}
		[HttpPost]
		public ActionResult EditCategory(Category category)
		{
			cm.CategoryUpdateBL(category);
			return RedirectToAction("Index");
		}
	}
}