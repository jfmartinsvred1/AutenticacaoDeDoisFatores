using Microsoft.AspNetCore.Identity;

namespace AutenticacaoDeDoisFatores.Models
{
    public class User : IdentityUser
    {
        public bool Validator { get; set; } = false;
        public User() : base()
        {

        }
    }
}
