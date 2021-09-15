// -----------------------------------------------------------------------
// <copyright file="UserRole.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Core
{
    using Furion.DatabaseAccessor;

    /// <summary>
    /// 用户和角色关系表.
    /// </summary>
    public class UserRole : IEntity
    {
        /// <summary>
        /// Gets or sets the UserId
        /// 用户Id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the User
        /// 一对一引用.
        /// </summary>
        public User User { get; set; }

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
    }
}
