using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ShopAppNew.interfaces;
using ShopAppNew.Logs;
using ShopAppNew.Models;
using ShopAppNew.Repository;
using System.IO;

namespace ShopAppNew
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IHostingEnvironment hostEnv, IConfiguration configuration)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddMvc();

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger, ILoggerFactory loggerFactory)
        {
            // Записываем логи в файл
            /*loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "logger.txt"));
            var logg = loggerFactory.CreateLogger("FileLogger");

            app.Run(async (context) =>
            {
                logg.LogInformation("Processing request {0}", context.Request.Path);
                await context.Response.WriteAsync("Hello World!");
            }); */
            // Логирование в консоль
            /* app.Run(async (context) => 
             {
                 // пишем на консоль информацию
                 logger.LogInformation("Processing request {0}", context.Request.Path);
                 //или так
                 //logger.LogInformation($"Processing request {context.Request.Path}");

                 await context.Response.WriteAsync("1X BET!");
             }); */
            //Фабрика Логерра
            /* var loggerFactory = LoggerFactory.Create(builder =>
             {
                 builder.AddConsole();
                 builder.AddDebug(); //Output вижлы
                 // настройка фильтров
                 builder.AddFilter("System", LogLevel.Debug)
                 .AddFilter<DebugLoggerProvider>("Microsoft", LogLevel.Trace);
             });
             ILogger logger = loggerFactory.CreateLogger<Startup>();
             app.Run(async (context) =>
             {
                 logger.LogInformation("Requested Path: {0}", context.Request.Path);
                 await context.Response.WriteAsync("1X BET!");
             }); */

            // Подключение бд с категориями и ставками
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
            // Подключение бд пользователей
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();

            app.UseAuthentication();    // подключение аутентификации

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
