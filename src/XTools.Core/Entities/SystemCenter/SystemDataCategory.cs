// -----------------------------------------------------------------------
// <copyright file="SystemDataCategory.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;
    using Furion.DatabaseAccessor;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 数据字典类别.
    /// </summary>
    public class SystemDataCategory : Entity, IEntityTypeBuilder<SystemDataCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemDataCategory"/> class.
        /// </summary>
        public SystemDataCategory()
        {
            CreatedTime = DateTimeOffset.Now;
            IsDeleted = false;
            Sequence = 0;
            Enabled = true;
        }

        /// <summary>
        /// Gets or sets the Name
        /// 分类名称.
        /// </summary>
        [Required, MaxLength(32)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 分类描述.
        /// </summary>
        [MaxLength(200)]
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the Sequence
        /// 序号/排序.
        /// </summary>
        [Required]
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets the HigherId
        /// 上级分类 Id.
        /// </summary>
        public int? HigherId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the Higher
        /// 上级分类.
        /// </summary>
        public SystemDataCategory Higher { get; set; }

        /// <summary>
        /// Gets or sets the Sublevels
        /// 次级列表.
        /// </summary>
        public ICollection<SystemDataCategory> Sublevels { get; set; }

        /// <summary>
        /// Gets or sets the Data
        /// 分组数据.
        /// </summary>
        public ICollection<SystemData> Data { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsDeleted
        /// 软删除.
        /// </summary>
        [JsonIgnore]
        public virtual bool IsDeleted { get; set; }

        /// <summary>
        /// 配置实体.
        /// </summary>
        /// <param name="entityBuilder">.</param>
        /// <param name="dbContext">.</param>
        /// <param name="dbContextLocator">.</param>
        public void Configure(EntityTypeBuilder<SystemDataCategory> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder
                .HasMany(x => x.Sublevels)
                .WithOne(x => x.Higher)
                .HasForeignKey(x => x.HigherId);
        }
    }
}
