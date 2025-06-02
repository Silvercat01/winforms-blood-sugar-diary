using System.Text;
using BloodSugarClassLibrary.Data;

namespace BloodSugarClassLibrary.Services
{

    public enum LoginResult
    {
        Success,
        InvalidPassword,
        UserNotFound,
        AlreadyExists,
        EmptyFields
    }

    public class AuthService
    {

        private readonly UserContext _context;

        public AuthService(UserContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); ;
        }

        private string HashPassword(string password)
        {
            using (var sha512 = System.Security.Cryptography.SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha512.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public LoginResult Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return LoginResult.EmptyFields;

            var existingUser = _context.Users.FirstOrDefault(u => u.Username == username);

            if (existingUser == null)
                return LoginResult.UserNotFound;

            string hashedPassword = HashPassword(password);

            if (existingUser.Password == hashedPassword)
                return LoginResult.Success;
            else
                return LoginResult.InvalidPassword;
        }

        public LoginResult SignUp(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return LoginResult.EmptyFields;

            if (_context.Users.Any(u => u.Username == username))
                return LoginResult.AlreadyExists;

            var newUser = new User(username, HashPassword(password));

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return LoginResult.Success;
        }

    }
}
