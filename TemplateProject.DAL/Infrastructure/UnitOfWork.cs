using System;
using Microsoft.EntityFrameworkCore;
using TemplateProject.Model;

namespace TemplateProject.DAL.UnitOfWork {
	public class UnitOfWork : IDisposable {
		private DbContext _context;
		public UnitOfWork(DbContext context) {
			_context = context;
		}

		private Repository<User> _userRepository;

		public Repository<User> UserRepository {
			get {
				if (_userRepository == null) {
					_userRepository = new Repository<User>(_context);
				}
				return _userRepository;
			}
		}

		public void Save() {
			_context.SaveChanges();
		}

		private bool disposed = false;

		protected virtual void Dispose(bool disposing) {
			if (!this.disposed) {
				if (disposing) {
					_context.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}