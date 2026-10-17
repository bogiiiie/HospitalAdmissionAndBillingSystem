using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class UserController
	{
		private readonly UserRepository repository = new UserRepository();

		public List<User> GetAllUsers()
		{
			return repository.GetAllUsers();
		}

		public string ResetPassword(string username, string newPassword)
		{
			if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 6)
				return "Password must be at least 6 characters long.";

			string hash = ComputeSha256Hash(newPassword);
			repository.UpdatePassword(username, hash);
			return "OK";
		}

		private string ComputeSha256Hash(string rawData)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("X2")); // Uppercase hex
				}
				return builder.ToString();
			}
		}
	}
}