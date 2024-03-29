﻿// -----------------------------------------------------------------------
// <copyright file="SystemDataCategorySeedData.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Core.SeedData
{
    using System;
    using System.Collections.Generic;
    using Furion.DatabaseAccessor;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// 数据字典分类种子数据.
    /// </summary>
    public class SystemDataCategorySeedData : IEntitySeedData<SystemDataCategory>
    {
        /// <summary>
        /// 种子数据.
        /// </summary>
        /// <param name="dbContext">.</param>
        /// <param name="dbContextLocator">.</param>
        /// <returns>.</returns>
        public IEnumerable<SystemDataCategory> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new List<SystemDataCategory>
            {
                new SystemDataCategory { Id=1,CreatedTime =DateTimeOffset.Parse("2020-12-22 15:30:20"),IsDeleted=false,Name="性别",Remark="性别",Sequence=0,Enabled=true },
            };
        }
    }
}
