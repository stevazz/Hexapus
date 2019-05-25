using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hexapus.Authentication
{
    public class AccountDbContext : IdentityDbContext<IdentityUser>
    {
        public AccountDbContext(DbContextOptions options) : base(options) { }
    }
}
