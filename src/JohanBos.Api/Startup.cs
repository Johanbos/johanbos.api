using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Http;
using GraphQL.Server;
using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using JohanBos.Api.Types;
using JohanBos.Data;
using JohanBos.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JohanBos.Api
{
    public class Startup
    {
        private readonly IHostingEnvironment HostingEnvironment;

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            HostingEnvironment = hostingEnvironment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHealthChecks();
            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            services.AddTransient<IPassionAreaRepository, Data.Json.PassionAreaRepository>();
            services.AddTransient<IAchievementRepository, Data.Json.AchievementRepository>();
            services.AddTransient<IEmployerRepository, Data.Json.EmployerRepository>();
            services.AddTransient<IBioRepository, Data.Json.BioRepository>();
            services.AddTransient<IBioService, BioService>();
            services.AddTransient<IHistoryService, HistoryService>();
            services.AddTransient<BioType>();
            services.AddTransient<PassionAreaType>();
            services.AddTransient<EmployerType>();
            services.AddTransient<AchievementType>();
            services.AddTransient<GraphQLQuery>();
            services.AddSingleton<ISchema, GraphQLSchema>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddGraphQL(g =>
            {
                g.EnableMetrics = true;
                g.ExposeExceptions = HostingEnvironment.IsDevelopment();
            })
            .AddUserContextBuilder(httpContext => new GraphQLUserContext());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHealthChecks("/health");
            app.UseGraphQL<ISchema>("/graphql");
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                Path = "/graphqlui"
            });
        }
    }
}
