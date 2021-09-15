// -----------------------------------------------------------------------
// <copyright file="Security.cs" author="imbatony">
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

    /// <summary>
    /// 权限表.
    /// </summary>
    public class Security : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Security"/> class.
        /// </summary>
        public Security()
        {
            CreatedTime = DateTimeOffset.Now;
            IsDeleted = false;
            Enabled = true;
        }

        /// <summary>
        /// Gets or sets the UniqueName
        /// 权限唯一名（每一个接口）.
        /// </summary>
        [Required, MaxLength(100)]
        public string UniqueName { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 全新描述.
        /// </summary>
        [Required, MaxLength(200)]
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the Roles
        /// 多对多.
        /// </summary>
        public ICollection<Role> Roles { get; set; }

        /// <summary>
        /// Gets or sets the RoleSecurities
        /// 多对多中间表.
        /// </summary>
        public List<RoleSecurity> RoleSecurities { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsDeleted
        /// 软删除.
        /// </summary>
        [JsonIgnore]
        public virtual bool IsDeleted { get; set; }
    }
}
