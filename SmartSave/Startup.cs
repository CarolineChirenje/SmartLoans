﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartDataAccess;
using SmartHelper;
using SmartLogic;
using SmartLogic.IService;

namespace SmartSave
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            
            Configuration = configuration;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            string _configValue = GetData.SSDBConnection;
            if(string.IsNullOrEmpty(_configValue))
            _configValue = "Data Source=172.105.28.87;Initial Catalog=SmartSave; User Id=sa; Password=Ch1gumbu6299##";
            services.AddDbContext<DatabaseContext>(options =>
       options.UseSqlServer(_configValue));

            // setup dependency injection in service container
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IEmailTemplateService, EmailTemplateService>();
            services.AddScoped<ITransactionService, TransactionService>();
           
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<ICourseService, CourseService>();
            
            services.AddScoped<INoticeBoardService, NoticeBoardService>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IDocumentTypeService, DocumentTypeService>();
            services.AddScoped<ICustomSettingsService, CustomSettingsService>();
            services.AddScoped<ITransactionTypeService, TransactionTypeService>();
            services.AddScoped<IBankAccountservice, BankAccountService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IFeatureFlagService, FeatureFlagService>();

            // Add MVC services to the services container.
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
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
            // IMPORTANT: This session call MUST go before UseMvc()
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
