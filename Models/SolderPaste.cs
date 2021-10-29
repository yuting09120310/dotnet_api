using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class SolderPaste
    {
        public string 錫膏編號 { get; set; }
        public DateTime 取出時間 { get; set; }
        public string 重量 { get; set; }
        public string 取用人員 { get; set; }
        public string 攪拌時間 { get; set; }
        public double? 回溫時數 { get; set; }
        public string 執行人員 { get; set; }
        public string 確認人員 { get; set; }
        public string 錫膏廠牌 { get; set; }
        public string 錫膏型號 { get; set; }
        public string 報廢原因 { get; set; }
        public string 報廢時間 { get; set; }
        public string 報廢人員 { get; set; }
        public string 報廢確認 { get; set; }
        public int? 旗標 { get; set; }
    }
}
