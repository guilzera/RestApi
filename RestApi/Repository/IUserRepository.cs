using RestApi.Dato.VO;
using RestApi.Models;

namespace RestApi.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
