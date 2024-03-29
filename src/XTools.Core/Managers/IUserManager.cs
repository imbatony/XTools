﻿// -----------------------------------------------------------------------
// <copyright file="IUserManager.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// 用户管理接口.
    /// </summary>
    public interface IUserManager
    {
        /// <summary>
        /// Gets the UserId
        /// 获取用户 Id.
        /// </summary>
        int UserId { get; }

        /// <summary>
        /// Gets the User
        /// 获取用户信息.
        /// </summary>
        User User { get; }

        /// <summary>
        /// 检查用户是否有效.
        /// </summary>
        /// <param name="userId">.</param>
        /// <param name="tracking">.</param>
        /// <returns>.</returns>
        Task<User> CheckUserAsync(int userId, bool tracking = true);

        /// <summary>
        /// 查询用户权限.
        /// </summary>
        /// <param name="userId">.</param>
        /// <returns>.</returns>
        Task<List<Security>> GetSecuritiesAsync(int userId);
    }
}
