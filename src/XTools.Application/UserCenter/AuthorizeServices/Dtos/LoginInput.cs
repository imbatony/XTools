// -----------------------------------------------------------------------
// <copyright file="LoginInput.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    using System.ComponentModel.DataAnnotations;
    using Furion.DependencyInjection;

    /// <summary>
    /// 登录模型.
    /// </summary>
    [SuppressSniffer]
    public class LoginInput
    {
        /// <summary>
        /// Gets or sets the Account
        /// 用户名.
        /// </summary>
        [Required(ErrorMessage = "用户名不能为空"), MinLength(3, ErrorMessage = "用户名不能少于 3 位字符")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the Password
        /// 密码.
        /// </summary>
        [Required(ErrorMessage = "用户名不能为空"), MinLength(5, ErrorMessage = "密码不能少于 5 位字符")]
        public string Password { get; set; }
    }
}
