using Core.Entities;


namespace Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);                 
        Task AddAsync(User user);                       
                  
        Task DeleteAsync(int id);                         
    }
}
