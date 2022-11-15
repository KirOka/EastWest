using DataAccess.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess.Implementation
{
    public abstract class Repository<T, TPrimaryKey> : IRepository<T, TPrimaryKey> where T : class, IEntity<TPrimaryKey>
    {
        protected readonly DbContext Context;
        protected DbSet<T> EntitySet;

        protected Repository(DbContext context)
        {
            Context = context;
            EntitySet = Context.Set<T>();
        }

        /// <summary>
        /// Запросить все сущности в базе
        /// </summary>
        /// <returns>Список сущностей</returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await EntitySet.ToListAsync();
        }

        /// <summary>
        /// Получить сущность по ID
        /// </summary>
        /// <param name="id">ID сущности</param>
        /// <returns>сущность</returns>
        public virtual async Task<T> GetAsync(TPrimaryKey id)
        {
            return await EntitySet.FindAsync(id);
        }

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="id">ID удалённой сущности</param>
        /// <returns>была ли сущность удалена</returns>
        public virtual bool Delete(TPrimaryKey id)
        {
            var obj = EntitySet.Find(id);
            if (obj == null)
            {
                return false;
            }
            EntitySet.Remove(obj);
            Context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="entity">сущность для удаления</param>
        /// <returns>была ли сущность удалена</returns>
        public virtual bool Delete(T entity)
        {
            if (entity == null)
            {
                return false;
            }
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Для сущности проставить состояние - что она изменена
        /// </summary>
        /// <param name="entity">сущность для изменения</param>
        public virtual void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        /// <summary>
        /// Добавить в базу одну сущность
        /// </summary>
        /// <param name="entity">сущность для добавления</param>
        /// <returns>добавленная сущность</returns>
        public virtual async Task<T> AddAsync(T entity)
        {
            var ret = (await Context.Set<T>().AddAsync(entity)).Entity;
            await Context.SaveChangesAsync();
            return ret;
        }
    }
}