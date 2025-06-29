using SerenityRCM.Application.Repositories;
using SerenityRCM.Domain.Entities;
using SerenityRCM.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace SerenityRCM.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(DataContext context) : base(context)
    {
    }
    
    public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
}