using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using EmprendeUCR_WebApplication.Domain.Core.Helpers;
using EmprendeUCR_WebApplication.Domain.Core.ValueObjects;
using EmprendeUCR_WebApplication.Domain.OrderContext.Entities;
using EmprendeUCR_WebApplication.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using EmprendeUCR.IntegrationTests.EmprendeUCR;
using EmprendeUCR_WebApplication;

namespace EmprendeUCR.IntegrationTests.OrderContext.Infraestructure.Repositories
{
    public class OrderRepositoryIntegrationTest : IClassFixture<EmprendeUCRWebApplicationFactory<Startup>>
    {
        private readonly EmprendeUCRWebApplicationFactory<Startup> _factory;

        public OrderRepositoryIntegrationTest(EmprendeUCRWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetAllOrdersByEmail()
        {
            const int orderCount = 2;
            string entrepreneurEmail = "saguilar1999@hotmail.com";
            // arrange
            var repository = _factory.Server.Services.GetRequiredService<IOrderRepository>();

            // act
            var teams = await repository.GetByIdAsync(entrepreneurEmail);

            // assert
            teams.Should().HaveCount(orderCount);
        }

    }
}
