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
	public class MovieManager : IMovieService
	{
		IMovieDal _movieDal;
		public MovieManager(IMovieDal movieDal)
		{
			_movieDal = movieDal;
		}

		public Movie GetById(int id)
		{
			return _movieDal.getComment(id);
		}

		public List<Movie> GetList()
		{
			return _movieDal.List();
		}

		public void MovieAddBL(Movie movie)
		{
			_movieDal.Insert(movie);
		}

		public void MovieDeleteBL(Movie movie)
		{
			_movieDal.Delete(movie);
		}

		public void MovieUpdateBL(Movie movie)
		{
			_movieDal.Update(movie);
		}
	}
}
