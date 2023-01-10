﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SignalRApp {
    public class Startup {
        public void ConfigureServices(IServiceCollection services) {
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app) {
            app.UseDeveloperExceptionPage();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapHub<ChatHub>("/chat");
            });
        }
    }
}