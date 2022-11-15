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
    public class OrderController : ControllerBase
    {
        private IOrderService _service;
        private IMapper _mapper;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderService service, ILogger<OrderController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_mapper.Map<OrderModel>(await _service.GetById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Add(OrderModel order)
        {
            return Ok(await _service.Create(_mapper.Map<OrderDTO>(order)));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, OrderModel order)
        {
            await _service.Update(id, _mapper.Map<OrderDTO>(order));
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
            return Ok(_mapper.Map<List<OrderModel>>(await _service.GetAll()));
        }
    }
}
