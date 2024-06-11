using boba_API.Models;
using boba_API.Models.Dto;
using System.Collections.Generic;

namespace First_API_beta2.Mapper
{
    public static class UserClientMapper
    {
        public static ClientDTO ToClientDto(this Client client, IList<string> cars, IList<string> roles)
        {
            return new ClientDTO
            {
                Roles = new List<string>(roles),
                Cars =  new List<string>(cars),
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email
            };
        }
    }
}