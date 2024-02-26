using Customers.API.Controllers;
using Customers.API.Utility;
using Customers.Application.Customers.Dtos;
using Customers.Application.Customers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Customers.Test
{
    public class CustomerController
    {
        [Fact]
        public async Task Test_GetCustomersEndpoint()
        {

            var mockService = new Mock<ICustomersService>();
            mockService.Setup(service => service.GetAllCustomers())
                .ReturnsAsync(new List<GetCustomers>());

            var controller = new CustomersController(mockService.Object);

            var result = await controller.GetCustomers();

            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            var response = Assert.IsType<Response<List<GetCustomers>>>(okObjectResult.Value);

            Assert.True(response.status);
            Assert.NotNull(response.value);
            Assert.Empty(response.value);

        }

        [Fact]
        public async Task Test_SaveCustomersEndpoint()
        {

            var mockService = new Mock<ICustomersService>();
            mockService.Setup(service => service.CreateCustomers(It.IsAny<CreateCustomers>()))
                .ReturnsAsync(new GetCustomers());

            var controller = new CustomersController(mockService.Object);

            var result = await controller.SaveCustomers(new CreateCustomers());

            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            var response = Assert.IsType<Response<GetCustomers>>(okObjectResult.Value);

            Assert.True(response.status);
            Assert.NotNull(response.value);

        }

        [Fact]
        public async Task Test_EditCustomersEndpoint()
        {

            var mockService = new Mock<ICustomersService>();
            mockService.Setup(service => service.UpdateCustomers(It.IsAny<UpdateCustomers>()))
                .ReturnsAsync(true);

            var controller = new CustomersController(mockService.Object);

            var result = await controller.EditCustomers(new UpdateCustomers());

            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            var response = Assert.IsType<Response<bool>>(okObjectResult.Value);

            Assert.True(response.status);
            Assert.True(response.value);

        }

        [Fact]
        public async Task Test_DeleteCustomersEndpoint()
        {
            
            var mockService = new Mock<ICustomersService>();
            mockService.Setup(service => service.EliminateCustomers(It.IsAny<int>()))
                .ReturnsAsync(true);

            var controller = new CustomersController(mockService.Object);

            var result = await controller.DeleteCustomers(1);

            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            var response = Assert.IsType<Response<bool>>(okObjectResult.Value);

            Assert.True(response.status);
            Assert.True(response.value);

        }

    }

}