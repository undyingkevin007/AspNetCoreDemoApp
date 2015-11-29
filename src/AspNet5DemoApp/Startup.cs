﻿using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AspNet5DemoApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}