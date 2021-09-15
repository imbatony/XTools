// -----------------------------------------------------------------------
// <copyright file="AddUserInput.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 新增用户信息.
    /// </summary>
    public class AddUserInput : ModifyUserInput
    {
        /// <summary>
        /// Gets or sets the Account
        /// 账号.
        /// </summary>
        [Required(ErrorMessage = "账号不能为空"), StringLength(32, MinimumLength = 2, ErrorMessage = "账号需在 2 到 32 个字符之间")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the Password
        /// 密码.
        /// </summary>
        [Required(ErrorMessage = "密码不能为空"), StringLength(32, MinimumLength = 5, ErrorMessage = "密码需在 5 到 32 个字符之间")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the ConfirmPassword
        /// 确认密码.
        /// </summary>
        [Required(ErrorMessage = "确认密码不能为空"), Compare(nameof(Password), ErrorMessage = "两次密码输入不一致")]
        public string ConfirmPassword { get; set; }
    }
}
