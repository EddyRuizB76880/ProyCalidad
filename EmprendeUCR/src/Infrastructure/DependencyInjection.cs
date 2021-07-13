﻿using System.Net.Mime;
using EmprendeUCR.Domain.PaymentMethods.Repositories;
using EmprendeUCR.Domain.PaymentInfos.Repositories;
using EmprendeUCR.Infrastructure.PaymentMethods;
using EmprendeUCR.Infrastructure.PaymentMethods.Repositories;
using EmprendeUCR.Infrastructure.PaymentInfos.PaymentInformation;
using EmprendeUCR.Infrastructure.PaymentInfos.PaymentInformation.Repositories;
using EmprendeUCR.Infrastructure.PaymentInfos.SinpeMovil;
using EmprendeUCR.Infrastructure.PaymentInfos.SinpeMovil.Repositories;
using EmprendeUCR.Infrastructure.PaymentInfos.SinpeIban;
using EmprendeUCR.Infrastructure.PaymentInfos.SinpeIban.Repositories;
using EmprendeUCR.Infrastructure.PaymentInfos.Card;
using EmprendeUCR.Infrastructure.PaymentInfos.Card.Repositories;
using EmprendeUCR.Infrastructure.PaymentInfos.HasPaymentInfos;
using EmprendeUCR.Infrastructure.PaymentInfos.HasPaymentInfos.Repositories;

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
            services.AddScoped<ISinpeMovilPaymentMethodRepository, SinpeMovilPaymentMethodRepository>();
            services.AddScoped<ISinpeIbanPaymentMethodRepository, SinpeIbanPaymentMethodRepository>();
            services.AddScoped<ICardPaymentMethodRepository, CardPaymentMethodRepository>();
            services.AddDbContext<PaymentInfoDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IPaymentInfoRepository, PaymentInfoRepository>();
            services.AddDbContext<SinpeMovilPaymentInfoDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<ISinpeMovilPaymentInfoRepository, SinpeMovilPaymentInfoRepository>();
            services.AddDbContext<SinpeIbanPaymentInfoDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<ISinpeIbanPaymentInfoRepository, SinpeIbanPaymentInfoRepository>();
            services.AddDbContext<CardPaymentInfoDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<ICardPaymentInfoRepository, CardPaymentInfoRepository>();
            services.AddDbContext<HasPaymentInfoDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IHasPaymentInfoRepository, HasPaymentInfoRepository>();
            return services;
        }
    }
}