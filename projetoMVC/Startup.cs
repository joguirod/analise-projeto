using Microsoft.EntityFrameworkCore;
using projetoMVC.Models;
public class Startup
{
    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
        Environment = env;
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    public IWebHostEnvironment Environment { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<MyDbContext>(options =>
        {
            var connectionString = Configuration.GetConnectionString("MyDbContext");

            if (Environment.IsDevelopment())
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
            else
            {
                //options.UseSqlServer(connectionString);
            }
        });
    }   
}
