using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Services.Abstractions;
using DataAccess.Entities;
using EastWest.Models;
using Microsoft.AspNetCore.Mvc;

namespace EastWest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionController : ControllerBase
    {
        private IPositionService _service;
        private IMapper _mapper;
        private readonly ILogger<PositionController> _logger;

        public PositionController(IPositionService service, ILogger<PositionController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<PositionModel>(await _service.GetById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PositionModel position)
        {
            return Ok(await _service.Create(_mapper.Map<PositionDTO>(position)));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, PositionModel position)
        {
            await _service.Update(id, _mapper.Map<PositionDTO>(position));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetList()
        {
            return Ok(_mapper.Map<List<PositionModel>>(await _service.GetAll()));
        }
    }
}
