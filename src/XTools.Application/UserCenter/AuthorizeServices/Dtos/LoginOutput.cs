// -----------------------------------------------------------------------
// <copyright file="LoginOutput.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    using System;
    using Furion.DependencyInjection;

    /// <summary>
    /// 登录模型.
    /// </summary>
    [SuppressSniffer]
    public class LoginOutput
    {
        /// <summary>
        /// Gets or sets the Id
        /// 用户Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Account
        /// 用户名.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the AccessToken
        /// Token.
        /// </summary>
        public string AccessToken { get; set; }

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
        /// Gets or sets the SigninedTime
        /// 最近登录时间.
        /// </summary>
        public DateTimeOffset SigninedTime { get; set; }
    }
}
