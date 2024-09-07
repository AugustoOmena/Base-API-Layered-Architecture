using Microsoft.EntityFrameworkCore;
using PreciseiChamei.Domain.Entities;
using PreciseiChamei.Domain.Interfaces;
using PreciseiChamei.Persistence.Context;

namespace PreciseiChamei.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken) ?? throw new InvalidOperationException();
    }
}