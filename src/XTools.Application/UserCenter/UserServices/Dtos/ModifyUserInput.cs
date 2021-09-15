// -----------------------------------------------------------------------
// <copyright file="ModifyUserInput.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    using System.ComponentModel.DataAnnotations;
    using XTools.Core;

    /// <summary>
    /// 编辑用户信息.
    /// </summary>
    public class ModifyUserInput
    {
        /// <summary>
        /// Gets or sets the Nickname
        /// 昵称.
        /// </summary>
        [Required(ErrorMessage = "昵称不能为空"), StringLength(32, MinimumLength = 2, ErrorMessage = "昵称必须在 2 到 16 个字符之间")]
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
        [MaxLength(200, ErrorMessage = "简介不能超过 100 个字符")]
        public string Synopsis { get; set; }

        /// <summary>
        /// Gets or sets the Gender
        /// 性别.
        /// </summary>
        [Required(ErrorMessage = "性别不能为空")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; } = true;
    }
}
