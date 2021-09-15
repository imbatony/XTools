// -----------------------------------------------------------------------
// <copyright file="EditSystemDataInput.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.SystemCenter.Dtos
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 数据字典信息输入参数.
    /// </summary>
    public class EditSystemDataInput
    {
        /// <summary>
        /// Gets or sets the Name
        /// 名称.
        /// </summary>
        [Required(ErrorMessage = "名称不能为空"), StringLength(32, MinimumLength = 2, ErrorMessage = "名称需在2到32个字符之间")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 描述.
        /// </summary>
        [StringLength(100, ErrorMessage = "描述最大只能输入100个字符")]
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the Sequence
        /// 序号/排序.
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; } = true;
    }
}
