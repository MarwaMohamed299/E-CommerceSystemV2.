using E_CommerceSystemV2.API.CustomGlobalErrorHandler;
using E_CommerceSystemV2.API.SqlLocalizerProvider;
using E_CommerceSystemV2.BL.Managers.CampaignCustomer;
using E_CommerceSystemV2.BL.Managers.Identity;
using E_CommerceSystemV2.BL.Managers.Products;
using E_CommerceSystemV2.BL.Services.MailService;
using E_CommerceSystemV2.DAL.Data.Models;
using E_CommerceSystemV2.DAL.Repos.CampaignsCustomers;
using E_CommerceSystemV2.DAL.Repos.Products;
using E_CommerceSystemV2.DAL.Repos.Users;
using E_CommerceSystemV2.DAL.UnitOfWork;
using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Globalization;
using System.Security.Claims;
using System.Text;

namespace E_CommerceSystemV2.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           #region ConnectionString
            var ConnectionString = builder.Configuration.GetConnectionString("E-CommerceSystemV2");
            builder.Services.AddDbContext<ECommerceContext>(options => options.UseSqlServer(ConnectionString));
            #endregion

            #region Identity

            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 5;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            })
                .AddEntityFrameworkStores<ECommerceContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "default";
                options.DefaultScheme = "default";
            })

            .AddJwtBearer("default", options =>
            {
                //GenerateKey

                var secretKey = builder.Configuration.GetValue<string>("SecretKey");
                var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKey!);
                var Key = new SymmetricSecurityKey(secretKeyInBytes);

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = Key

                };
            });


            //builder.Services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("User", policy =>
            //    {
            //        policy.RequireClaim(ClaimTypes.Role, "User");
            //    });
            //});

            #endregion

            #region DefaultServices
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            #endregion

            #region SerilogConfig
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration)
                .CreateLogger();
            builder.Host.UseSerilog();

            #endregion

            #region Hang Fire Config
            builder.Services.AddHangfire(x => x.UseSqlServerStorage(ConnectionString));
            builder.Services.AddHangfireServer();
            #endregion

            #region CORS Policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllDomains", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
            #endregion

            #region Custom Services

            builder.Services.AddTransient<MailingService>();
            builder.Services.AddScoped<IProductRepo, ProductRepo>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<ICampaignsCustomersRepo, CampaignsCustomersRepo>();
            builder.Services.AddScoped<IUserRepo, UserRepo>();



            builder.Services.AddScoped<IUserManager, UserManager>();
            builder.Services.AddScoped<IProductsManager, ProductsManager>();
            builder.Services.AddScoped<ICampaignCustomerManager, CampaignCustomersManager>();

            builder.Services.AddExceptionHandler<GlobalErrorHandler>(); //Transient
            builder.Services.AddProblemDetails();

            #endregion

            #region Custom Sql Provider
            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo>
                    {
                        new CultureInfo("en-Us"),
                        new CultureInfo("ar-EG")
                    };
                options.DefaultRequestCulture = new RequestCulture(culture: "en", uiCulture: "Us");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            builder.Services.AddLocalization();
            builder.Services.AddSingleton<IStringLocalizerFactory, SqlLocalzerFactory>();

            #endregion

            var app = builder.Build();

            #region MiddleWares

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseRequestLocalization();
            app.UseSerilogRequestLogging(); 
            app.UseHttpsRedirection();
            app.UseAuthentication();
            
            app.UseAuthorization();
            app.UseExceptionHandler();
            app.UseHangfireDashboard("/dashboard");
            app.UseCors("AllowAllDomains");


            app.MapControllers();
            #endregion

            app.Run();
        }
    }
}