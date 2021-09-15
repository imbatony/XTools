// -----------------------------------------------------------------------
// <copyright file="EditSystemDataCategoryInput.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.SystemCenter.Dtos
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 数据字典分类信息.
    /// </summary>
    public class EditSystemDataCategoryInput
    {
        /// <summary>
        /// Gets or sets the Name
        /// 分类名称.
        /// </summary>
        [Required(ErrorMessage = "名称不能为空"), StringLength(32, MinimumLength = 2, ErrorMessage = "名称需在 2 到 32 个字符之间")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 分类描述.
        /// </summary>
        [StringLength(200, ErrorMessage = "描述最大只能输入 100 个字符")]
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the Sequence
        /// 序号/排序.
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets the HigherId
        /// 上级分类 Id.
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "上级分类Id编号从1开始或为空")]
        public int? HigherId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Enabled
        /// 是否启用.
        /// </summary>
        public bool Enabled { get; set; } = true;
    }
}
