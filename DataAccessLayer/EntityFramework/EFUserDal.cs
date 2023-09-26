using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EFUserDal : GenericRepository<User>, IUserDal
	{
		

		public User CheckUser(User user)
		{
			
			var userSel  = c.Users.ToList().Find(x=>x.Username==user.Username);
			if (userSel != null)
			{
				if (userSel.Password == user.Password)
				{
					return userSel;
				}
				else return null;
			}else
			{ return null; }


		}
	}
}
