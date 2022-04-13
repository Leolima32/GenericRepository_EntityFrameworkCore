﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GenericRepository.EntityFrameworkCore.ServiceInjection
{
    public static class ServicesExtension
    {
        public static void AddGenericRepositorySqlServer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<GenericDbContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}