﻿using EmprendeUCR.Application.PaymentMethods;
using EmprendeUCR.Application.PaymentMethods.Implementations;
using EmprendeUCR.Application.PaymentInfos;
using EmprendeUCR.Application.PaymentInfos.Implementations;
using EmprendeUCR.Application.Categories;
using EmprendeUCR.Application.Categories.Implementations;
using Microsoft.Extensions.DependencyInjection;
namespace EmprendeUCR.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IPaymentMethodService, PaymentMethodService>();
            //services.AddTransient<IIBANCardPaymentInfoService, IBANCardPaymentInfoService>();
            //services.AddTransient<ICategoryService, CategoryService>();
            return services;
        }
    }
}