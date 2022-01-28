using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TouristHostpot.API.Filter;
using TouristHotspot.Application.Commands.CreateTourSpot;
using TouristHotspot.Application.Validators;
using TouristHotspot.Core.Repositories;
using TouristHotspot.Infrastructure.Persistence;
using TouristHotspot.Infrastructure.Persistence.Repositories;

namespace TouristHostpot.API
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
            var connectionString = Configuration.GetConnectionString("TouristHotspotCs");
            services.AddDbContext<TouristHotspotDbContext>(options=>options.UseSqlServer(connectionString));

            services.AddScoped<ITourSpotRepository, TourSpotRepository>();

            services.AddCors();

            services.AddControllers(options=>options.Filters.Add(typeof(ValidationFilter)))
                .AddFluentValidation(fv=>fv.RegisterValidatorsFromAssemblyContaining<CreateTourSpotCommandValidator>());

            services.AddMediatR(typeof(CreateTourSpotCommand));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TouristHostpot.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TouristHostpot.API v1"));
            }
            app.UseCors(builder => builder
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

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
