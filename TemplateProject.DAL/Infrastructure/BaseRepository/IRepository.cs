using Microsoft.EntityFrameworkCore;
using TemplateProject.DAL.UnitOfWork;

namespace TemplateProject.DAL.BaseRepository {
	interface IRepository<TEntity> {
		IUnitOfWork<DbContext> _unitOfWork { get; }
		TEntity Get(int Id);
		void Delete(int Id);
	}
}
