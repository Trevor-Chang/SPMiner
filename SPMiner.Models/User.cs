﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SPMiner.Models
{
    public partial class User
    {
        public int Id { get; set; }
        /// <summary>
        /// 社交平台ID
        /// </summary>
        public string SocialId { get; set; }
        /// <summary>
        /// 使用者名稱
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 使用者社交平台上的照片
        /// </summary>
        public string UserPicture { get; set; }
        /// <summary>
        /// 平台類別(FB、IG etc.)
        /// </summary>
        public int SocialType { get; set; }
        /// <summary>
        /// 當同一使用者有其他帳號要綁定在當前帳號上時,使用Parent找出上層主帳號
        /// </summary>
        public int? ParentId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Creator { get; set; }
        public DateTime? EditDate { get; set; }
        public int? Editor { get; set; }
        public int Status { get; set; }
    }
}