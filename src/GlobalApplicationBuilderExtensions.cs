using System;
using System.Collections.Generic;
using System.Text;
using Hangfire.Annotations;
using Hangfire.Dashboard.Management.v2.Support;
using Hangfire.Server;
using Microsoft.AspNetCore.Builder;

namespace Hangfire.Dashboard.Management.v2
{
    public static class GlobalApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseHangfireDashboardManagement([NotNull] this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }

            JobsHelper.ApplicationServices = app.ApplicationServices;

            return app;
        }
    }
}

