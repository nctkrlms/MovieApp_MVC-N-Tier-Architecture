using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EFMovieDal : GenericRepository<Movie>, IMovieDal
	{
		public Movie getComment(int id)
		{
			return c.Movies.Include("Comments").FirstOrDefault(x=>x.MovieId == id);
		}
	}
}
