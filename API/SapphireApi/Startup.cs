using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using SapphireApi.Data;
using SapphireApi.Data.Identity;

namespace SapphireApi
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
            //Custom Dependency injection
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            services.AddHttpContextAccessor();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SapphireApi", Version = "v1" });
            });
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("----        CONNECTION STRING        ----");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine( Configuration.GetConnectionString("MYSQL"));
            Console.WriteLine("-----------------------------------------");

            services.AddDbContext<Sapphire_Context>(
                options => {
                    // options.UseSqlServer(
                    //     Configuration.GetConnectionString("Default")
                    // );
                    options.UseMySQL(
                        Configuration.GetConnectionString("MYSQL")
                    );
                }
                
            );

            services
                .AddIdentity<UserModel, IdentityRole>(options => {
                    options.Password.RequireDigit = true;
                    options.Password.RequiredLength = 8;
                    options.Password.RequiredUniqueChars = 0;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequireUppercase = true;
                })
                .AddEntityFrameworkStores<Sapphire_Context>();

            services
                .AddControllers()
                .AddNewtonsoftJson(
                    options => {
                        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    }
                );

            var origin = Configuration["AppSettings:Client_Url"].ToString();

            services
                .AddCors(
                    options => {
                        options.AddDefaultPolicy(
                            builder => {
                                builder
                                    .AllowAnyOrigin()
                                    .AllowAnyHeader()
                                    .AllowAnyMethod();
                            }
                        );
                    }
                );

            // JWT
            // the key must have at least 16 characters
            var strKey = Configuration["AppSettings:JWT_Secret"].ToString();
            var key = Encoding.UTF8.GetBytes(strKey);

            services.AddAuthentication(
                builder =>{
                    builder.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    builder.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    builder.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                }
            ).AddJwtBearer(options=>{
                // Define your own configuration
                options.RequireHttpsMetadata = false;
                options.SaveToken = false;
                options.TokenValidationParameters = new TokenValidationParameters{

                    // Desviación del reloj
                    ClockSkew = TimeSpan.Zero,

                    ValidateIssuer = false,

                    ValidateAudience = false,

                    ValidateIssuerSigningKey = true,
                    // this is the secret key for JWT
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
            });

            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, Sapphire_Context db)
        {
            app.UseCors();
            if (!env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SapphireApi v1"));
            }else{
                app.UseHttpsRedirection();
            }


            app.UseRouting();


            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            if( db.Database.GetPendingMigrations().Count() > 0 ) 
                db.Database.Migrate();
        }
    }
}
