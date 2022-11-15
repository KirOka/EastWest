using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Services.Abstractions;
using EastWest;
using EastWest.Controllers;
using EastWest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace web_api_tests
{
    public class OrderControllerTest
    {
        private readonly OrderController _controller;
        private readonly IOrderService _service;

        public OrderControllerTest()
        {
            _service = new OrderServiceFake();
            ILogger<OrderController> logger = null;
            IMapper mapper = new Mapper(MapperConfig.GetMapperConfiguration());
            _controller = new OrderController(_service, logger, mapper);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.GetList();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = (await _controller.GetList()) as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<OrderModel>>(okResult.Value);
            Assert.Equal(2, items.Count);
        }

        [Fact]
        public async void GetById_ExistingIdPassed_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.Get(1);
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
        [Fact]
        public async void GetById_ExistingIdPassed_ReturnsRightItem()
        {
            // Act
            var okResult = (await _controller.Get(1)) as OkObjectResult;
            // Assert
            Assert.IsType<OrderModel>(okResult.Value);
            Assert.Equal("Test1", (okResult.Value as OrderModel).Name);
        }

        [Fact]
        public async void Add_ReturnsOkResult()
        {
            OrderModel order = new OrderModel() { Name = "Test5", Positions = new List<PositionModel>() };
            order.Positions.Add(new PositionModel() { ProductCode = 159357, Price = 10 });
            // Act
            var okResult = await _controller.Get(1);
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public async void Edit_ReturnsOkResult()
        {
            OrderModel order = new OrderModel() { Name = "Test6" };
            // Act
            var okResult = await _controller.Edit(1, order);
            // Assert
            Assert.IsType<OkResult>(okResult as OkResult);
        }

        [Fact]
        public async void Delete_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.Delete(1);
            // Assert
            Assert.IsType<OkResult>(okResult as OkResult);
        }
    }
}