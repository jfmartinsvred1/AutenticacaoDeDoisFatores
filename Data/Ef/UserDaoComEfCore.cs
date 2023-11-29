using AutenticacaoDeDoisFatores.Data.Dto;
using AutenticacaoDeDoisFatores.Models;
using AutoMapper;
using Google.Authenticator;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoDeDoisFatores.Data.Ef
{
    public class UserDaoComEfCore : IUserDao
    {
        IMapper _mapper;
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;

        public UserDaoComEfCore(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task IncluirAsync(CreateUserDto dto)
        {
            User user = _mapper.Map<User>(dto);

            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Falha Ao Cadastrar O Usuario!");
            }
        }

        public async Task LogarAsync(LoginUsuarioDto dto)
        {
            var resultado = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password,false,false);

            if (!resultado.Succeeded)
            {
                throw new ApplicationException("Usuario nao autenticado");
            }
            
        }

    }
}
