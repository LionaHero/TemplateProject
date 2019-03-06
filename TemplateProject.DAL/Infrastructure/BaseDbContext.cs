using Microsoft.EntityFrameworkCore;
using TemplateProject.Model;

namespace TemplateProject.DAL {
	public class BaseDbContext : DbContext {
		public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder) {
			base.OnModelCreating(builder);

			builder.Entity<User>().ToTable("User", "acc");
		}
	}
}
