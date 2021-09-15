// -----------------------------------------------------------------------
// <copyright file="SystemData.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Core
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;
    using Furion.DatabaseAccessor;

    /// <summary>
    /// 数据字典.
    /// </summary>
    public class SystemData : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemData"/> class.
        /// </summary>
        public SystemData()
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
        /// Gets or sets the CategoryId
        /// 所属分类Id.
        /// </summary>
        [Required]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the Category
        /// 所属分类.
        /// </summary>
        public SystemDataCategory Category { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsDeleted
        /// 软删除.
        /// </summary>
        [JsonIgnore]
        public virtual bool IsDeleted { get; set; }
    }
}
