using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using FundooManager.ManagerImplementation;
using FundooManager.ManagerInterface;
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
using FundooRepository.FundooContext;
using FundooRepository.RepositoryImplementation;
using FundooRepository.RepositoryInterface;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.Filters;

namespace FundooNotes
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
           /* services.AddSingleton<Context>();*/
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountManager, AccountManager>();
            services.AddTransient<ILabelRepository, LabelRepository>();
            services.AddTransient<ILabelManager, LabelManager>();
            services.AddTransient<INoteRepository, NoteRepository>();
            services.AddTransient<INoteManager, NoteManager>();
            services.AddTransient<ICollaboratorManager, CollaboratorManager>();
            services.AddTransient<ICollaboratorRepository, CollaboratorRepository>();
           
            services.Configure<DataProtectionTokenProviderOptions>(option =>
            option.TokenLifespan = TimeSpan.FromHours(1));

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
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
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

            app.UseAuthentication();

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FundooNoteAPI v1");
            });


        }
    }
}