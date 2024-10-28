
namespace Core.Services
{
    public interface IAuthService
    {

        Task<bool> CheckEmailExistAsync(string email);
        Task<bool> CheckIcNumberExistAsync(string IcNumber);
        Task<bool> CheckPhoneNumberExistAsync(string number);

    }
}
