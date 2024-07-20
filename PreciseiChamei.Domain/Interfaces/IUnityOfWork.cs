namespace PreciseiChamei.Domain.Interfaces;

public interface IUnityOfWork
{
    Task Commit(CancellationToken cancellationToken);
}