// -----------------------------------------------------------------------
// <copyright file="SystemDataCategoryProfile.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.SystemCenter.Dtos
{
    /// <summary>
    /// 数据字典分类信息.
    /// </summary>
    public class SystemDataCategoryProfile
    {
        /// <summary>
        /// Gets or sets the Id
        /// 分类 Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// 分类名称.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 分类描述.
        /// </summary>
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
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the HigherId
        /// 上级分类 Id.
        /// </summary>
        public int? HigherId { get; set; }
    }
}
