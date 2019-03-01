using Microsoft.EntityFrameworkCore;

namespace TemplateProject.DAL.UnitOfWork {
	public class UnitOfWork : IUnitOfWork<DbContext> {
		public UnitOfWork(DbContext dbContext) {
			DbContext = dbContext;
		}

		public void SaveChanges() { }

		public DbContext DbContext { get; }
	}
}
