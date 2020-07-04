using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreManager.ManagerImplementation;
using BookStoreManager.ManagerInterfaces;
using BookStoreRepository.BookStoreContext;
using BookStoreRepository.RepositoryImplementation;
using BookStoreRepository.RepositoryInterfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Swagger;

namespace BookStoreApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
           /* LogManager.LoadConfiguration(System.String.Concat(Directory.GetCurrentDirectory(), "/NLog.Config"));*/
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddTransient<IAccountManager, AccountManager>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IBookManager, BookManager>();
            services.AddTransient<IAddBookRepository, AddBookRepository>();
            services.Configure<DataProtectionTokenProviderOptions>(option =>
            option.TokenLifespan = TimeSpan.FromHours(24));

            var secretKey = Configuration["Jwt:key"];
            var symmerticKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:_url"],
                    ValidAudience = Configuration["Jwt:_url"],
                    IssuerSigningKey = symmerticKey,
                    RequireExpirationTime = true
                };
            });


            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();

            }));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "FundooNoteAPI",
                });
                c.AddSecurityDefinition("oauth2", new ApiKeyScheme
                {
                    Description = "jwt bearer token",
                    Name = "Authorization",
                    Type = "apiKey",
                    In = "header"
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("MyPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FundooNoteAPI v1");
            });
        }
    }
}
