using PreciseiChamei.Domain.Interfaces;
using PreciseiChamei.Persistence.Context;

namespace PreciseiChamei.Persistence.Repositories;

public class UnitOfWork : IUnityOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    
    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}