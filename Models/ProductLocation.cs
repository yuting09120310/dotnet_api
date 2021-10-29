using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class ProductLocation
    {
        public string Flag { get; set; }
        public string 部門 { get; set; }
        public string 編號 { get; set; }
        public string 名稱 { get; set; }
        public string 作業系統 { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string 硬碟 { get; set; }
        public string 客戶財編 { get; set; }
        public DateTime? 預計保養 { get; set; }
        public string 保養週期 { get; set; }
        public DateTime? 校正日期 { get; set; }
        public DateTime? 購入日期 { get; set; }
        public string 保管人 { get; set; }
        public string 儲位 { get; set; }
        public string 移轉 { get; set; }
        public string 報廢人員 { get; set; }
        public string 報廢原因 { get; set; }
        public DateTime? 初盤日期 { get; set; }
        public string 初盤人員 { get; set; }
        public DateTime? 覆盤日期 { get; set; }
        public string 覆盤人員 { get; set; }
        public string 人員 { get; set; }
        public DateTime? 時間 { get; set; }
        public string 備註 { get; set; }
    }
}
