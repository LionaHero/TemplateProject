using Microsoft.EntityFrameworkCore;

namespace TemplateProject.DAL.UnitOfWork {
	interface IUnitOfWork<TContext>
		where TContext : DbContext {

		void SaveChanges();
		TContext DbContext { get; }
	}
}
