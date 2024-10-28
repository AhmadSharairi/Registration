using Core.Entities;
using Core.Interfaces;

namespace Core.Services
{
    public class UserService : IUserService
    {
       
         private readonly IUserRepository _userRepo;
    
        public UserService(IUserRepository userRepo)
        {
               _userRepo = userRepo;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepo.GetByIdAsync(id);
        }

        public async Task DeleteUserAsync(int id)
        {
            await  _userRepo.DeleteAsync(id);
        }

  
        

    }
}
