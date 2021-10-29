using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Purchase
    {
        public string 請購單號 { get; set; }
        public DateTime 請購日期 { get; set; }
        public string 申請單位 { get; set; }
        public string 請購人員 { get; set; }
        public string 產品編號 { get; set; }
        public string 品名規格 { get; set; }
        public string 數量 { get; set; }
        public string 單位 { get; set; }
        public string 急單 { get; set; }
        public string 列帳 { get; set; }
        public string 產編號碼 { get; set; }
        public string 編立日期 { get; set; }
        public string 廠商代號 { get; set; }
        public string 廠商 { get; set; }
        public string Po { get; set; }
        public string 出貨日 { get; set; }
        public string 用途說明 { get; set; }
    }
}
