using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNet_Core_Identity.Data
{
    public class AuthDbContext:IdentityDbContext
    {
     public AuthDbContext(DbContextOptions<AuthDbContext>options):base (options)
     {
         
     }   
    }
}