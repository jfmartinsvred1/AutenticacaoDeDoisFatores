using AutenticacaoDeDoisFatores.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoDeDoisFatores.Data
{
    public interface IUserDao
    {
        public Task IncluirAsync(CreateUserDto dto);
        Task LogarAsync(LoginUsuarioDto dto);

    }
}
