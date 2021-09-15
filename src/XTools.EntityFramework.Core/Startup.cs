// -----------------------------------------------------------------------
// <copyright file="Startup.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.EntityFramework.Core
{
    using Furion;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Defines the <see cref="Startup" />.
    /// </summary>
    public class Startup : AppStartup
    {
        /// <summary>
        /// The ConfigureServices.
        /// </summary>
        /// <param name="services">The services<see cref="IServiceCollection"/>.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "XTools.Database.Migrations");
        }
    }
}
