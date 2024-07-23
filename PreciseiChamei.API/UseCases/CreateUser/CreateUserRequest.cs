using MediatR;

namespace PreciseiChamei.API.UseCases.CreateUser;

public sealed record CreateUserRequest(string Email, string Name) :
    IRequest<CreateUserResponse>
{
    
}