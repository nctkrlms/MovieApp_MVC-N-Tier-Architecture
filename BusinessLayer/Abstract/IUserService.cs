using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IUserService
	{
		List<User> GetList();
		void UserAddBL(User user);
		User GetById(int id);
		void UserDeleteBL(User user);
		void UserUpdateBL(User user);
		User UserCheck(User user);
	}
}
