﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace TemplateProject.DAL {
	public class Repository<TEntity> where TEntity : class {
		internal DbContext context;
		internal DbSet<TEntity> dbSet;

		public Repository(DbContext context) {
			this.context = context;
			this.dbSet = context.Set<TEntity>();
		}

		public virtual IEnumerable<TEntity> Get(
			Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null) {
			IQueryable<TEntity> query = dbSet;

			if (filter != null) {
				query = query.Where(filter);
			}

			if (orderBy != null) {
				return orderBy(query).ToList();
			} else {
				return query.ToList();
			}
		}

		public virtual TEntity GetById(object id) {
			return dbSet.Find(id);
		}

		public virtual void Insert(TEntity entity) {
			dbSet.Add(entity);
		}

		public virtual void Delete(object id) {
			TEntity entityToDelete = dbSet.Find(id);
			Delete(entityToDelete);
		}

		public virtual void Delete(TEntity entityToDelete) {
			if (context.Entry(entityToDelete).State == EntityState.Detached) {
				dbSet.Attach(entityToDelete);
			}
			dbSet.Remove(entityToDelete);
		}

		public virtual void Update(TEntity entityToUpdate) {
			dbSet.Attach(entityToUpdate);
			context.Entry(entityToUpdate).State = EntityState.Modified;
		}
	}
}