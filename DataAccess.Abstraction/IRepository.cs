using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstraction
{
    public interface IRepository<T, TPrimaryKey> where T : class, IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Запросить все сущности в базе
        /// </summary>
        /// <returns>Список сущностей</returns>
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// Получить сущность по ID
        /// </summary>
        /// <param name="id">ID сущности</param>
        /// <returns>сущность</returns>
        Task<T> GetAsync(TPrimaryKey id);

        /// <summary>
        /// Добавить в базу одну сущность
        /// </summary>
        /// <param name="entity">сущность для добавления</param>
        /// <returns>добавленная сущность</returns>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="id">ID удалённой сущности</param>
        /// <returns>была ли сущность удалена</returns>
        bool Delete(TPrimaryKey id);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="entity">сущность для удаления</param>
        /// <returns>была ли сущность удалена</returns>
        bool Delete(T entity);

        /// <summary>
        /// Для сущности проставить состояние - что она изменена
        /// </summary>
        /// <param name="entity">сущность для изменения</param>
        void Update(T entity);
    }
}
