// -----------------------------------------------------------------------
// <copyright file="SystemDataProfile.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Application.SystemCenter.Dtos
{
    /// <summary>
    /// 数据字典信息.
    /// </summary>
    public class SystemDataProfile
    {
        /// <summary>
        /// Gets or sets the Id
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// 名称.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Remark
        /// 描述.
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
        /// Gets or sets the CategoryId
        /// 所属分类Id.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the CategoryName
        /// 所属分类名.
        /// </summary>
        public string CategoryName { get; set; }
    }
}
