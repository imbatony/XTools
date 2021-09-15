// -----------------------------------------------------------------------
// <copyright file="EditRoleInput.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.UserCenter
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 新增角色输入参数.
    /// </summary>
    public class EditRoleInput
    {
        /// <summary>
        /// Gets or sets the Name
        /// 角色名称.
        /// </summary>
        [Required(ErrorMessage = "名称不能为空"), StringLength(32, MinimumLength = 2, ErrorMessage = "名称需在 2 到 32 个字符之间")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 角色描述.
        /// </summary>
        [StringLength(200, ErrorMessage = "描述最大只能输入 100 个字符")]
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; } = true;
    }
}
