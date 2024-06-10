using boba_API.Models;
using boba_API.Models.Dto;

namespace First_API_beta2.Mapper;

public static class AdvancedUserMappers
{
  public static AdvancedUserDTO ToAdvancedUserDTO(User userModel, IList<string> roles)
  {
    return new AdvancedUserDTO()
    {
      Roles = roles,
      FirstName = userModel.FirstName,
      LastName = userModel.LastName,
      Email = userModel.Email
    };
  }
}
