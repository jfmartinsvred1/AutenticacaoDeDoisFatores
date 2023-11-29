using AutenticacaoDeDoisFatores.Data.Dto;
using AutenticacaoDeDoisFatores.Models;
using AutoMapper;

namespace AutenticacaoDeDoisFatores.Profiles
{
    public class UsuarioProfile:Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<LoginUsuarioDto, User>(); 
        }
    }
}
