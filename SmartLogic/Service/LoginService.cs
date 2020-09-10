using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;

namespace SmartLogic
{
    public class LoginService : ILoginService
    {
        private readonly DatabaseContext _context;

        public LoginService()
        {

        }

        public LoginService(DatabaseContext context) => _context = context;

        

        public async Task<User> Login(string username, string password)
        {
            string encryptedPassword = Encryption.Encrypt(password);
            return await _context.Users.FirstOrDefaultAsync(u => u.EmailAddress == username &&
             u.Password == encryptedPassword);

        }
    }
}
