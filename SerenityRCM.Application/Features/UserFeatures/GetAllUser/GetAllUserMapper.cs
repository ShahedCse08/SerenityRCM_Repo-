using AutoMapper;
using SerenityRCM.Domain.Entities;

namespace SerenityRCM.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}