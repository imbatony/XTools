// -----------------------------------------------------------------------
// <copyright file="DefaultDbContext.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.EntityFramework.Core
{
    using Furion.DatabaseAccessor;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="DefaultDbContext" />.
    /// </summary>
    [AppDbContext("XTools", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultDbContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{DefaultDbContext}"/>.</param>
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}
