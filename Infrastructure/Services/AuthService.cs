using Microsoft.EntityFrameworkCore;



namespace Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }


        public Task<bool> CheckEmailExistAsync(string email)
          => _context.Users.AnyAsync(x => x.Email == email);

        public Task<bool> CheckIcNumberExistAsync(string icNumber)
         => _context.Users.AnyAsync(x => x.IcNumber == icNumber);

        public Task<bool> CheckPhoneNumberExistAsync(string number)
        => _context.Users.AnyAsync(x => x.PhoneNumber == number);




    }
}
