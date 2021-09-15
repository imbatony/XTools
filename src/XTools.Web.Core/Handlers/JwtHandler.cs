// -----------------------------------------------------------------------
// <copyright file="JwtHandler.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Web.Core
{
    using System.Linq;
    using System.Threading.Tasks;
    using Furion.Authorization;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using XTools.Core;

    /// <summary>
    /// Defines the <see cref="JwtHandler" />.
    /// </summary>
    public class JwtHandler : AppAuthorizeHandler
    {
        /// <summary>
        /// The PipelineAsync.
        /// </summary>
        /// <param name="context">The context<see cref="AuthorizationHandlerContext"/>.</param>
        /// <param name="httpContext">The httpContext<see cref="DefaultHttpContext"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public override async Task<bool> PipelineAsync(AuthorizationHandlerContext context, DefaultHttpContext httpContext)
        {
            return await CheckAuthorzieAsync(httpContext);
        }

        /// <summary>
        /// 检查权限.
        /// </summary>
        /// <param name="httpContext">.</param>
        /// <returns>.</returns>
        private static async Task<bool> CheckAuthorzieAsync(DefaultHttpContext httpContext)
        {
            // 获取权限特性
            var securityDefineAttribute = httpContext.GetMetadata<SecurityDefineAttribute>();
            if (securityDefineAttribute == null) return true;

            // 解析服务
            var userManager = httpContext.RequestServices.GetService<IUserManager>();
            var securities = await userManager.GetSecuritiesAsync(userManager.UserId);

            // 检查授权
            return securities.Select(u => u.UniqueName).Contains(securityDefineAttribute.ResourceId);
        }
    }
}
