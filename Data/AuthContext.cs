using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutenticacaoDeDoisFatores.Data
{
    public class AuthContext:IdentityDbContext<User>
    {
        public AuthContext(DbContextOptions<AuthContext> opts):base(opts)
        {
            
        }
    }
}
