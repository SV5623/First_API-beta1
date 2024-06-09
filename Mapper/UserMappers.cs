using boba_API.Models;
using boba_API.Models.Dto;

namespace First_API_beta2.Mapper;

public static class UserMappers
{
    public static UserDTO ToUserDto(this User userModel)
    {
        return new UserDTO()
        {
            FirstName = userModel.FirstName,
            LastName = userModel.LastName,
            Email = userModel.Email
        };
    }
}