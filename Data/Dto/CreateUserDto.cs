using System.ComponentModel.DataAnnotations;

namespace AutenticacaoDeDoisFatores.Data.Dto
{
    public class CreateUserDto
    {
        [Required]
        public string Username { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        public string RePassword { get; set; }

    }
}
