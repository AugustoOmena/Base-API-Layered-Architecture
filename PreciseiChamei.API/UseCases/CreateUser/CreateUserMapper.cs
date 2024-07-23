using AutoMapper;
using PreciseiChamei.Domain.Entities;

namespace PreciseiChamei.API.UseCases.CreateUser;

public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();
    }
}