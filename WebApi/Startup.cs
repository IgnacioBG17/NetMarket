using BusinessLogic.Data;
using BusinessLogic.Logic;
using Core.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Dtos;
using WebApi.Middleware;
public class Startup
{
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public void ConfigureServices(IServiceCollection services)
    {
        //Configurar AutoMapper
        services.AddAutoMapper(typeof(MappingProfiles));

        // Al arrancar la aplicacion se generara un GenericRepository por cada request del cliente
        services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));

        services.AddDbContext<MarketDbContext>(opt =>
        {
            opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });

        // Cuando inicie la aplicacion que se cree un ProductoRepository
        services.AddTransient<IProductoRepository, ProductoRepository>();
        services.AddControllers();

        //para permitir a cualquier cliente consumir esta API
        services.AddCors(opt =>
        {
            opt.AddPolicy("CorsRule", rule =>
            {
                rule.AllowAnyHeader().AllowAnyMethod().WithOrigins("*");
            });
        });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        //if (env.IsDevelopment())
        //{
        //    app.UseDeveloperExceptionPage();
        //}
        app.UseMiddleware<ExceptionMiddleware>();

        // para que ejecute el nuevo controlador de error
        app.UseStatusCodePagesWithReExecute("/errors", "?code={0}");

        // Para los controloladores
        app.UseRouting();

        app.UseCors("CorsRule");

        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

