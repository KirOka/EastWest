using BusinessLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Abstractions
{
    /// <summary>
    /// Cервис работы с позициями (интерфейс)
    /// </summary>
    public interface IPositionService
    {
        /// <summary>
        /// Получить список
        /// </summary>
        /// <returns></returns>
        Task<ICollection<PositionDTO>> GetAll();

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО позиции</returns>
        Task<PositionDTO> GetById(int id);

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="positionDTO">ДТО позиции</para
        Task<int> Create(PositionDTO positionDTO);

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="positionDTO">ДТО позиции</param>
        Task Update(int id, PositionDTO positionDTO);

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        Task Delete(int id);
    }
}
