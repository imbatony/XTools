// -----------------------------------------------------------------------
// <copyright file="IAuthorizeService.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// 授权服务接口.
    /// </summary>
    public interface IAuthorizeService
    {
        /// <summary>
        /// 用户登录.
        /// </summary>
        /// <param name="httpContextAccessor">.</param>
        /// <param name="input">.</param>
        /// <returns>.</returns>
        Task<LoginOutput> LoginAsync([FromServices] IHttpContextAccessor httpContextAccessor, [Required] LoginInput input);
    }
}
