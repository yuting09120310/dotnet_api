using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class DipOven
    {
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 品名規格 { get; set; }
        public int 數量 { get; set; }
        public int 烘烤時數 { get; set; }
        public DateTime 烘烤開始時間 { get; set; }
        public DateTime 預計完成時間 { get; set; }
        public string 烘烤人員 { get; set; }
        public DateTime? 取出時間 { get; set; }
        public string 取出人員 { get; set; }
        public string 結案 { get; set; }
    }
}
