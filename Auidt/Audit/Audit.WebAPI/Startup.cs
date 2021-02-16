using Audit.Business.Abstract;
using Audit.Business.Concrete;
using Audit.DataAccess.Abstract;
using Audit.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audit.WebAPI
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
            services.AddControllers();
            services.AddSingleton<IHealthcareProviderService, HealthcareProviderManager>();
            services.AddSingleton<IHealthcareProviderDal, EfHealthcareProviderDal>();

            services.AddSingleton<IPersonService, PersonManager>();
            services.AddSingleton<IPersonDal, EfPersonDal>();

            services.AddSingleton<IReportService, ReportManager>();
            services.AddSingleton<IReportDal, EfReportDal>();

            services.AddSingleton<IPetitionService, PetitionManager>();
            services.AddSingleton<IPetitionDal, EfPetitionDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
