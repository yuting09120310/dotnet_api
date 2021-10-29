using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class ExcessAoiRepair
    {
        public string 單號 { get; set; }
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 料號 { get; set; }
        public int 數量 { get; set; }
        public string 領收人員 { get; set; }
        public string 領收時間 { get; set; }
    }
}
