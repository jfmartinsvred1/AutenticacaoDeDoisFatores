using Microsoft.AspNetCore.Identity;

namespace AutenticacaoDeDoisFatores.Data
{
    public class User:IdentityUser
    {
        public bool Validator { get; set; }
        public User():base()
        {
            
        }
    }
}
