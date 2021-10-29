using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Oven
    {
        public string 客戶別 { get; set; }
        public string 料號 { get; set; }
        public int 數量 { get; set; }
        public string 儲位 { get; set; }
        public string 烘烤時數 { get; set; }
        public DateTime 烘烤開始時間 { get; set; }
        public DateTime 預計完成時間 { get; set; }
        public string 烘烤人員 { get; set; }
        public DateTime? 取出時間 { get; set; }
        public string 取出人員 { get; set; }
        public string 結案 { get; set; }
    }
}
