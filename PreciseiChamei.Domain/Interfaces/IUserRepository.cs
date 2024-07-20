using PreciseiChamei.Domain.Entities;

namespace PreciseiChamei.Domain.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmail(string email, CancellationToken cancellationToken);
}