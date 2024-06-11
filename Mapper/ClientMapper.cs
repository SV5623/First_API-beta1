using boba_API.Models;
using boba_API.Models.Dto;

namespace First_API_beta2.Mapper;

public static class ClientMapper
{
    public static ClientDTO ToClientDto(User userModel, IList<string> cars, IList<string> roles)
    {
        return new ClientDTO()
        {
            Roles = roles,
            Cars = cars,
            FirstName = userModel.FirstName,
            LastName = userModel.LastName,
            Email = userModel.Email
        };
    }
}