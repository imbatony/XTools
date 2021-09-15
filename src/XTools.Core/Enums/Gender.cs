// -----------------------------------------------------------------------
// <copyright file="Gender.cs" author="imbatony">
//     Copyright (c) Weloveloli Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace XTools.Core
{
    using System.ComponentModel;

    /// <summary>
    /// 性别
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// 男
        /// </summary>
        [Description("男")]
        Male,
        /// <summary>
        /// 女
        /// </summary>
        [Description("女")]
        Female
    }
}
