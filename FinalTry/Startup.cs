using JobSeeker.BusinessLayer.BImplementation;
using JobSeeker.BusinessLayer.Interfaces;
using JobSeeker.DataLayer;
using JobSeeker.RepositoryLayer.Intefarces;
using JobSeeker.RepositoryLayer.Interfaces;
using JobSeeker.RepositoryLayer.RepoImplementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTry
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.DictionaryKeyPolicy = null;
            });
            services.AddDbContext<JSDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConStr")));
            services.AddSwaggerGen();
            services.AddControllersWithViews();
            services.AddScoped<IJSCourseServices, JSCourseServices>();
            services.AddScoped<IJSCourseRepo, JSCourseRepo>();
            services.AddScoped<IJSJobsServices, JSJobsServices>();
            services.AddScoped<IJSJobsRepo, JSJobsRepo>();
            services.AddScoped<IJSSkillServices, JSSkillServices>();
            services.AddScoped<IJSSkillRepo, JSSkillRepo>();
            services.AddScoped<IRegistrationServices, JSRegistrationServices>();
            services.AddScoped<IRegistrationRepo, JSRegistrationRepo>();
            services.AddScoped<IJSSessionServices, JSSessionServices>();    
            services.AddScoped<IJSSessionRepo, JSSessionRepo>();






        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger(options =>
            {
                options.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Session API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
