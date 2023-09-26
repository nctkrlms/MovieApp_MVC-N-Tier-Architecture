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
	public class UserManager : IUserService
	{
		IUserDal _userDal;
		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public User GetById(int id)
		{
			return _userDal.Get(x => x.UserId == id);
		}

		public List<User> GetList()
		{
			return _userDal.List();
		}

		public void UserAddBL(User user)
		{
			_userDal.Insert(user);
		}

		public User UserCheck(User user)
		{
			return _userDal.CheckUser(user);
		}

		public void UserDeleteBL(User user)
		{
			_userDal.Delete(user);
		}

		public void UserUpdateBL(User user)
		{
			_userDal.Update(user);
		}
	}
}
