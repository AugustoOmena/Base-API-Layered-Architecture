using AutoMapper;
using MediatR;
using PreciseiChamei.Domain.Entities;
using PreciseiChamei.Domain.Interfaces;

namespace PreciseiChamei.API.UseCases.CreateUser;

public class CreateUserHandler :
    IRequestHandler<CreateUserRequest, CreateUserResponse>
{
    private readonly IUnitOfWork _unityOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateUserHandler(IUnitOfWork unityOfWork, IUserRepository userRepository, IMapper mapper)
    {
        _unityOfWork = unityOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(request);
        
        _userRepository.Create(user);

        await _unityOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateUserResponse>(user);
    }
}