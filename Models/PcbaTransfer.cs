using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class PcbaTransfer
    {
        public string 製令 { get; set; }
        public string 工單 { get; set; }
        public string 機種 { get; set; }
        public string 客戶機種 { get; set; }
        public int 批量 { get; set; }
        public int? Aoi { get; set; }
        public int? Aoi1 { get; set; }
        public int? 外包 { get; set; }
        public int? 外包1 { get; set; }
        public int? 倉庫 { get; set; }
        public int? 倉庫1 { get; set; }
        public int? Dip { get; set; }
        public int? Dip1 { get; set; }
        public int? Dip2 { get; set; }
        public int? Qa { get; set; }
        public int? Qa1 { get; set; }
        public int? Test { get; set; }
        public int? Test1 { get; set; }
        public int? Test2 { get; set; }
        public int? 組包 { get; set; }
        public int? 組包1 { get; set; }
        public int? 組包2 { get; set; }
        public int? Oqc { get; set; }
        public int? Iqc { get; set; }
        public int? 生管 { get; set; }
        public string 備註 { get; set; }
    }
}
