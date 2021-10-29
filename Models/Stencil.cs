using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Stencil
    {
        public string 鋼板別 { get; set; }
        public int 流水號 { get; set; }
        public string 編號 { get; set; }
        public string 機種 { get; set; }
        public string 鋼板檔名 { get; set; }
        public string Pcb料號 { get; set; }
        public string 鋼板厚度 { get; set; }
        public string 鋼板尺寸 { get; set; }
        public DateTime? 製造日期 { get; set; }
        public string 業者製造編號 { get; set; }
        public string 客戶別 { get; set; }
        public DateTime? 進廠日期 { get; set; }
        public string 客供編號 { get; set; }
        public DateTime? 鋼板取用時間 { get; set; }
        public DateTime? 退還日期 { get; set; }
        public string 退還人 { get; set; }
        public DateTime? 報廢日期 { get; set; }
        public string 報廢通知 { get; set; }
        public DateTime? 拆除日期 { get; set; }
        public string 拆除通知 { get; set; }
        public string 備註 { get; set; }
        public string 附件1 { get; set; }
        public string 附件2 { get; set; }
        public string 附件3 { get; set; }
        public string 附件4 { get; set; }
        public string 附件5 { get; set; }
        public string 附件6 { get; set; }
        public string 附件7 { get; set; }
    }
}
