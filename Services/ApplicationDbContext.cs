using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		  : base(options)
		{
			UserWhoUsed = string.Empty;
			UserFrom = string.Empty;
		}

		public ApplicationDbContext()
			: base()
		{
			UserWhoUsed = string.Empty;
			UserFrom = string.Empty;
		}

		public string ConnectionString { get; set; }
		public string UserWhoUsed { get; set; }
		public string UserFrom { get; set; }
	}
}
