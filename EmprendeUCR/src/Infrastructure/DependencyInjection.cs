using System.Net.Mime;
using EmprendeUCR.Domain.PaymentMethods.Repositories;
using EmprendeUCR.Infrastructure.PaymentMethods;
using EmprendeUCR.Infrastructure.PaymentMethods.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace EmprendeUCR.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(
        this IServiceCollection services,
        string connectionString)
        {
            services.AddDbContext<PaymentMethodsDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            return services;
        }
    }
}