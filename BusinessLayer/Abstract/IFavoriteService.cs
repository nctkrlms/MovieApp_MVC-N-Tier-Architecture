using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IFavoriteService
	{
		List<Favorite> GetList();
		void FavoriteAddBL(Favorite favorite);
		Favorite GetById(int id);
		void FavoriteRemoveBL(Favorite favorite);
		void FavoriteUpdateBL(Favorite favorite);

	}
}
