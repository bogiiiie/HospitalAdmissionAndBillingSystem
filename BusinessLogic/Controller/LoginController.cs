using System;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class LoginController
	{
		private readonly UserRepository userRepository = new UserRepository();

		// TODO: Implement by Luster
		public string Login(string username, string password)
		{
			return "Not yet implemented";
		}
	}
}