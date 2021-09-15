// -----------------------------------------------------------------------
// <copyright file="UserProfile.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using XTools.Core;

namespace XTools.Application.UserCenter
{
    /// <summary>
    /// 用户信息.
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// Gets or sets the Id
        /// 用户 Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Account
        /// 账号.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the Nickname
        /// 昵称.
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the Photo
        /// 头像（OSS地址）.
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Gets or sets the Synopsis
        /// 简介.
        /// </summary>
        public string Synopsis { get; set; }

        /// <summary>
        /// Gets or sets the Gender
        /// 性别.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; }
    }
}
