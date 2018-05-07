﻿/*----------------------------------------------------------------------------*/
/* Source File:   STARTUP.CS                                                  */
/* Description:   Main entry point to configure ASP.NET Core Web Api app.     */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.04/2018                                                 */
/* Last Modified: May.07/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ.                                                */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 May.04/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using Insurance.Policy.Api.Repository;
using Insurance.Policy.Api.Repository.Interfaces;
using Insurance.Policy.Api.Services;
using Insurance.Policy.Api.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Insurance.Policy.Api.Helper.Consts;

namespace Insurance.Policy.Api
{
    /// <summary>
    /// Main entry point to configure ASP.NET Core Web Api app.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:User.Info.Startup"/> class.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var insurancePolicyRepository = new InsurancePolicyRepository(GlobalConstants.POSTGRESQL_CONN_STRING);
            services.AddSingleton<IInsurancePolicyRepository>(insurancePolicyRepository);
            services.AddSingleton<IInsurancePolicyService>(new InsurancePolicyService(insurancePolicyRepository));

            var coverageTypeRepository = new CoverageTypeRepository(GlobalConstants.POSTGRESQL_CONN_STRING);
            services.AddSingleton<ICoverageTypeRepository>(coverageTypeRepository);
            services.AddSingleton<ICoverageTypeService>(new CoverageTypeService(coverageTypeRepository));

            var riskTypeRepository = new RiskTypeRepository(GlobalConstants.POSTGRESQL_CONN_STRING);
            services.AddSingleton<IRiskTypeRepository>(riskTypeRepository);
            services.AddSingleton<IRiskTypeService>(new RiskTypeService(riskTypeRepository));

            var userRepository = new UserRepository(GlobalConstants.POSTGRESQL_CONN_STRING);
            services.AddSingleton<IUserRepository>(userRepository);
            services.AddSingleton<IUserService>(new UserService(userRepository));

            var userInsurancePolicyRepository = new UserInsurancePolicyRepository(GlobalConstants.POSTGRESQL_CONN_STRING);
            services.AddSingleton<IUserInsurancePolicyRepository>(userInsurancePolicyRepository);
            services.AddSingleton<IUserInsurancePolicyService>(new UserInsurancePolicyService(userInsurancePolicyRepository));

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                    });
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("AllowAll");
            app.UseMvc();
        }
    }
}
