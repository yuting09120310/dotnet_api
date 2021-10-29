using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class OvenInformation
    {
        public string 客戶別 { get; set; }
        public string 類別 { get; set; }
        public int 低溫烘烤 { get; set; }
        public int 高溫烘烤 { get; set; }
        public string 建立者 { get; set; }
    }
}
