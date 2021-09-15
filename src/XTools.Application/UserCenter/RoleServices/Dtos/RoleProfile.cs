// -----------------------------------------------------------------------
// <copyright file="RoleProfile.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    /// <summary>
    /// 角色信息.
    /// </summary>
    public class RoleProfile
    {
        /// <summary>
        /// Gets or sets the Id
        /// 角色 Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// 角色名称.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 角色描述.
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; }
    }
}
