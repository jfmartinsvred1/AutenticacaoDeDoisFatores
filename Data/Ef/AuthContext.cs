using AutenticacaoDeDoisFatores.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutenticacaoDeDoisFatores.Data.Ef
{
    public class AuthContext : IdentityDbContext<User>
    {
        public AuthContext(DbContextOptions<AuthContext> opts) : base(opts)
        {

        }
        public DbSet<ValidatorModel> ValidatorModels { get; set; }
    }
}
