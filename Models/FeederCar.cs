using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class FeederCar
    {
        public string 車號 { get; set; }
        public string 站別 { get; set; }
        public string 料架號碼 { get; set; }
        public string 作業人員 { get; set; }
        public string 掃描時間 { get; set; }
    }
}
