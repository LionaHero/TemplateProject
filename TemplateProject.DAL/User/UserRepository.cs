using System;
using Microsoft.EntityFrameworkCore;
using TemplateProject.DAL.UnitOfWork;
using TemplateProject.Model;

namespace TemplateProject.DAL {
	class UserRepository : IUserRepository {
		private IUnitOfWork<DbContext> unitOfWork;

		public UserRepository(IUnitOfWork<DbContext> unitOfWork) {
			this.unitOfWork = unitOfWork;
		}

		public IUnitOfWork<DbContext> _unitOfWork {
			get { return unitOfWork; }
		}

		public void Delete(int Id) {
			var user = _unitOfWork.DbContext.Set<User>().Find(Id);
			_unitOfWork.DbContext.Set<User>().Remove(user);
		}

		public User Get(int Id) {
			return _unitOfWork.DbContext.Set<User>().Find(Id);
		}
	}
}
