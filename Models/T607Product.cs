using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class T607Product
    {
        public string 製令 { get; set; }
        public string 工單 { get; set; }
        public string 機種 { get; set; }
        public string 客戶機種 { get; set; }
        public int 批量 { get; set; }
        public string SN { get; set; }
        public string SN建立人員 { get; set; }
        public string SN建立時間 { get; set; }
        public string 彩盒列印 { get; set; }
        public string 彩盒列印人員 { get; set; }
        public string 彩盒列印時間 { get; set; }
        public string Tx列印 { get; set; }
        public string Rx列印 { get; set; }
        public string 安規列印人員 { get; set; }
        public string 安規列印時間 { get; set; }
    }
}
