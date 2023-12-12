
using E_CommerceSystemV2.BL.Managers.Products;
using E_CommerceSystemV2.DAL.Repos.Products;
using Microsoft.EntityFrameworkCore;

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

            #region DefaultServices
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
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


            builder.Services.AddScoped<IProductRepo, ProductRepo>();
            builder.Services.AddScoped<IProductsManager, ProductsManager>();

            #endregion

            var app = builder.Build();
            #region MiddleWares

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors("AllowAllDomains");


            app.MapControllers();
            #endregion

            app.Run();
        }
    }
}