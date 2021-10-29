using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class FeederOnRecord
    {
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 製程面 { get; set; }
        public string 匯出時間 { get; set; }
        public string 匯出人員 { get; set; }
    }
}
