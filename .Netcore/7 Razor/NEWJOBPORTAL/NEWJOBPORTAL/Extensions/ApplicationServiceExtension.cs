
using NEWJOBPORTAL.Models;
//using Job_Portal_Management_System.Repositories;
//using Job_Portal_Management_System.Services;
using NEWJOBPORTAL.Extension;
using NEWJOBPORTAL.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using NEWJOBPORTAL.Helpers;

namespace NEWJOBPORTAL.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobManagementportalContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Add Services

            //services.AddScoped<IJobRepository, JobRepository>();
            //services.AddScoped<IJobService, JobService>();
            // Add AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}

