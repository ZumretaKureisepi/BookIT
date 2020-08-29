using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using BookIT.WebAPI.Database;
using BookIT.WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using BookIT.WebAPI.Filters;
using Microsoft.AspNetCore.Authentication;
using BookIT.WebAPI.Security;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BookIT.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }

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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "BookIT API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            var connection = @"Server=.;Database=BookIT_Zavrsni;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<BookITContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ISmjestajiService, SmjestajiService>();
            services.AddScoped<IGradoviService, GradoviService>();
            services.AddScoped<ISobeService, SobeService>();
            services.AddScoped<IDodatneUslugeService, DodatneUslugeService>();
            services.AddScoped<IDodatneUslugeSmjestajiService, DodatneUslugeSmjestajiService>();
            services.AddScoped<IFaktureService, FaktureService>();
            services.AddScoped<IDodatneUslugeRezervacijeService, DodatneUslugeRezervacijeService>();
            services.AddScoped<ISobeRezervacijeService, SobeRezervacijeService>();
            services.AddScoped<IRezervacijeService, RezervacijeService>();
            services.AddScoped<IUlogeService, UlogeService>();
            services.AddScoped<IDrzaveService, DrzaveService>();
            services.AddScoped<IDodatneUslugeSobeService, DodatneUslugeSobeService>();
            services.AddScoped<ISmjestajiSlikeService, SmjestajiSlikeService>();
            services.AddScoped<ISobeSlikeService, SobeSlikeService>();
            services.AddScoped<ISmjestajiOcjeneService, SmjestajiOcjeneService>();
            services.AddScoped<IPreporukaService, PreporukaService>();


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
                //app.UseHsts();
            }


            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookIT V1");
            });

            //app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
