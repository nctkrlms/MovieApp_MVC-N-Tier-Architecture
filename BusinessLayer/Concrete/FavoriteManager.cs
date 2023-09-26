using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class FavoriteManager : IFavoriteService
	{
		IFavoriteDal _favoriteDal;

		public FavoriteManager(IFavoriteDal favoriteDal)
		{
			_favoriteDal = favoriteDal;
		}
		public void FavoriteAddBL(Favorite favorite)
		{
			_favoriteDal.Insert(favorite);
		}

		public void FavoriteRemoveBL(Favorite favorite)
		{
			_favoriteDal.Delete(favorite);
		}

		public void FavoriteUpdateBL(Favorite favorite)
		{
			throw new NotImplementedException();
		}

		public Favorite GetById(int id)
		{
			return _favoriteDal.Get(x=> x.FavoriteId == id);
		}

		public List<Favorite> GetList()
		{
			return _favoriteDal.List();
		}
	}
}
