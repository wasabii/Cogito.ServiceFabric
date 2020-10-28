using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Cogito.ServiceFabric.Test.AspNetCore.WebService.NetCore3
{

    public class Startup
    {

        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("Hello World!");
            });
        }

    }

}
