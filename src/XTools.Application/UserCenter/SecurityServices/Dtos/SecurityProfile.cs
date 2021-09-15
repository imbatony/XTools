// -----------------------------------------------------------------------
// <copyright file="SecurityProfile.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    /// <summary>
    /// 权限信息.
    /// </summary>
    public class SecurityProfile
    {
        /// <summary>
        /// Gets or sets the Id
        /// 权限 Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the UniqueName
        /// 权限唯一名（每一个接口）.
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 全新描述.
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; }
    }
}
