using AutenticacaoDeDoisFatores.Data;
using AutenticacaoDeDoisFatores.Data.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoDeDoisFatores.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        IUserDao _userDao;
        IValidatorDao _validator;

        public UserController(IUserDao userDao, IValidatorDao validator)
        {
            _userDao = userDao;
            _validator = validator;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuarioAsync(CreateUserDto dto)
        {
            _userDao.IncluirAsync(dto);
            var qr = _validator.GenerateQrCode(dto.Email);
            return Ok(qr);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto loginUsuario)
        {
            await _userDao.LogarAsync(loginUsuario);
            return Ok("Usuario Logado");
        }

        [HttpPost("validatecode")]
        public ActionResult<string> ValidateCode(string code, string email)
        {

            return _validator.ValidateCode(code, email);
        }

    }
}
