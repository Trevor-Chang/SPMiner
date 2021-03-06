﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SPMiner.Models
{
    public partial class Admin
    {
        /// <summary>
        /// 資料編號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 帳號
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 信箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 資料建立日期
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 資料建立人員編號
        /// </summary>
        public int? Creator { get; set; }
        /// <summary>
        /// 資料異動日期
        /// </summary>
        public DateTime? EditDate { get; set; }
        /// <summary>
        /// 資料異動人員編號
        /// </summary>
        public int? Editor { get; set; }
        /// <summary>
        /// 資料狀態
        /// </summary>
        public int Status { get; set; }
    }
}