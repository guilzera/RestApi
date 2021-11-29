using RestApi.Data;
using RestApi.Dato.VO;
using RestApi.Models;
using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace RestApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RestApiContext _context;

        public UserRepository(RestApiContext context)
        {
            _context = context;
        }

        //Passa uma senha criptografada e ve se é igual a do banco de dados.
        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == pass);
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}
