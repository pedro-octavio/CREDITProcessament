using Autofac;
using CREDITProcessament.Data.Context;
using CREDITProcessament.Infra.IOC;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace CREDITProcessament.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation();

            services.AddDbContext<ApplicationDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CREDITProcessamentDB"), m => m.MigrationsAssembly(typeof(Startup).Assembly.ToString())));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "CREDITProcessament",
                    Version = "v1",
                    Description = "CREDITProcessament is a project to process credit from one or more users.",
                    Contact = new OpenApiContact
                    {
                        Name = "Pedro Oct�vio",
                        Email = "pedrooctavio.almeida@tcs.com",
                        Url = new Uri("https://github.com/pedro-octavio")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri("https://github.com/pedro-octavio/CREDITProcessament/blob/main/LICENSE")
                    }
                });
            });
        }

        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new ModuleIOC());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();

                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CREDITProcessament.Presentation v1"));
            }

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
