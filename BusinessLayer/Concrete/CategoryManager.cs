using EntityLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		//GenericRepository<Category> repo = new GenericRepository<Category>();

		//public List<Category> GetAllBL()
		//{
		//	return repo.List();
		//}
		//public void CategoryAddBL(Category p)
		//{
		//	repo.Insert(p);
		//	//    if(p.CategoryName == "" ||  p.CategoryName.Length <= 3 )
		//	//    {
		//	//        //hataa
		//	//    }
		//	//    else
		//	//    {
		//	//        
		//	//    }
		//	//}
		//}
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public List<Category> GetList()
		{
			return _categoryDal.List();
		}
		

		public void CategoryAddBL(Category category)
		{
			_categoryDal.Insert(category);

		}

		public Category GetById(int id)
		{
			return _categoryDal.Get(x => x.CategoryId == id);
		}

		public void CategoryRemoveBL(Category category)
		{
			_categoryDal.Delete(category);
		}

		public void CategoryUpdateBL(Category category)
		{
			_categoryDal.Update(category);
		}
	}
}
