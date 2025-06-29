using SerenityRCM.Domain.Entities;

namespace SerenityRCM.Application.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmail(string email, CancellationToken cancellationToken);
}