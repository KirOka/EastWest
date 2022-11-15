using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Services.Abstractions;
using DataAccess.Entities;
using DataAccess.Repositories.Abstractions;
using DataAccess.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Implementations
{
    /// <summary>
    /// Сервис работы с позициями
    /// </summary>
    public class PositionService : IPositionService
    {
        private readonly IMapper _mapper;
        private readonly IPositionsRepository _positionRepository;

        public PositionService(
            IMapper mapper,
            IPositionsRepository positionRepository)
        {
            _mapper = mapper;
            _positionRepository = positionRepository;
        }

        /// <summary>
        /// Получить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <returns>ДТО позиции</returns>
        public async Task<PositionDTO> GetById(int id)
        {
            var position = await _positionRepository.GetAsync(id);
            return _mapper.Map<PositionDTO>(position);
        }

        /// <summary>
        /// Создать
        /// </summary>
        /// <param name="positionDTO">ДТО позиции</param>
        /// <returns>идентификатор</returns>
        public async Task<int> Create(PositionDTO positionDTO)
        {
            var entity = _mapper.Map<PositionDTO, Position>(positionDTO);
            var res = await _positionRepository.AddAsync(entity);
            return res.Id;
        }

        /// <summary>
        /// Изменить
        /// </summary>
        /// <param name="id">идентификатор</param>
        /// <param name="positionDTO">ДТО позиции</param>
        public async Task Update(int id, PositionDTO positionDTO)
        {
            var entity = _mapper.Map<PositionDTO, Position>(positionDTO);
            entity.Id = id;
            _positionRepository.Update(entity);
        }

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id">идентификатор</param>
        public async Task Delete(int id)
        {
            _positionRepository.Delete(id);
        }

        /// <summary>
        /// Получить список
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<PositionDTO>> GetAll()
        {
            ICollection<Position> entities = await _positionRepository.GetAllAsync();
            return _mapper.Map<ICollection<Position>, ICollection<PositionDTO>>(entities);
        }
    }
}
