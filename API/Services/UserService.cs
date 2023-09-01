using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;

namespace API.Services
{
    public class UserService : IUserService
    {
        public Task<string> AddRoleAsync(AddRoleDto model)
        {
            throw new NotImplementedException();
        }

        public Task<DatosUsuarioDto> GetTokenAsync(LoginDto model)
        {
            throw new NotImplementedException();
        }

        public Task<string> RegisterAsync(RegisterDto model)
        {
            throw new NotImplementedException();
        }
    }
}