using System;
using GitHubExplorer.Entities;
using GitHubExplorer.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;
using StructureMap;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace GitHubExplorer
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<Settings>(_configuration.GetSection("Settings"));

            services.AddMvc();

            services.AddSwaggerGen(config => config.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" }));

            return new Container(config =>
            {
                config.Populate(services);
                config.For<IRestClient>().Use<RestClient>();
                config.For<IUserRepository>().Use<UserRepository>();
            }).GetInstance<IServiceProvider>();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(config => config.SwaggerEndpoint("/swagger/v1/swagger.json", "API"));

            app.UseMvcWithDefaultRoute();
        }
    }
}
