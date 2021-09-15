// -----------------------------------------------------------------------
// <copyright file="GetRoleListInput.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 获取角色列表参数.
    /// </summary>
    public class GetRoleListInput
    {
        /// <summary>
        /// Gets or sets the PageIndex
        /// 页码.
        /// </summary>
        [Required(ErrorMessage = "页码不能为空"), Range(1, int.MaxValue, ErrorMessage = ("页码只能在 1 到 2147483647 之间"))]
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// Gets or sets the PageSize
        /// 页容量.
        /// </summary>
        [Required(ErrorMessage = "页容量不能为空"), Range(5, 200, ErrorMessage = ("页码只能在 5 到 200 之间"))]
        public int PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the Keyword
        /// 关键字.
        /// </summary>
        public string Keyword { get; set; }
    }
}
