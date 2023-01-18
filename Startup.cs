using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ToDoListDDD.Domain.Handlers;
using ToDoListDDD.Domain.Repositories;
using ToDoListDDD.Domain.Services;
using ToDoListDDD.Infrastructure;
using ToDoListDDD.Business.Handlers.Interfaces;

namespace ToDoListDDD
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
            services.AddControllers();
            services.AddDbContext<ToDoDbContext>();
            services.AddTransient<IGetAllToDoItemsHandler, GetAllToDoItemsHandler>();
            services.AddTransient<IGetToDoByIdHandler, GetToDoByIdHandler>();
            services.AddTransient<ICreateToDoItemHandler, CreateToDoItemHandler>();
            services.AddTransient<IToDoRepository, ToDoRepository>();
            services.AddTransient<IGetAllToDoItemsHandler, GetAllToDoItemsHandler>();
            services.AddTransient<IRemoveToDoItemHandler, RemoveToDoItemHandler>();
            services.AddTransient<IUpdateToDoStatusHandler, UpdateToDoStatusHandler>();
            services.AddTransient<IGetIncompleteToDosHandler, GetIncompleteToDosHandler>();
            services.AddTransient<IToDoValidationService, ToDoValidationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
