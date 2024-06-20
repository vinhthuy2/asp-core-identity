using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearnCoreIdentity.WebApi
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        private string DbPath { get; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
            var folder = Path.GetDirectoryName("/Users/thtr/Documents/Projects_/DotNETLearn/learn_core_identity/DB/");
            DbPath = Path.Join(folder, "learnCoreIdentity.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // optionsBuilder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("AppDb"));
            optionsBuilder.UseSqlite($"Data source={DbPath}");
        }
    }
}
