// -----------------------------------------------------------------------
// <copyright file="RoleSecurity.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Core
{
    using Furion.DatabaseAccessor;

    /// <summary>
    /// 角色和权限关系表.
    /// </summary>
    public class RoleSecurity : IEntity
    {
        /// <summary>
        /// Gets or sets the RoleId
        /// 角色Id.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the Role
        /// 一对一引用.
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Gets or sets the SecurityId
        /// 权限Id.
        /// </summary>
        public int SecurityId { get; set; }

        /// <summary>
        /// Gets or sets the Security
        /// 一对一引用.
        /// </summary>
        public Security Security { get; set; }
    }
}
