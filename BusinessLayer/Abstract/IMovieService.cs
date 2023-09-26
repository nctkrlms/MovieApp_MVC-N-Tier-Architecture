using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IMovieService
	{
		List<Movie> GetList();
		void MovieAddBL(Movie movie);
		Movie GetById(int id);
		void MovieDeleteBL(Movie movie);
		void MovieUpdateBL(Movie movie);



	}
}
