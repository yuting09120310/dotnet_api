using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class DipConsumablesRecord
    {
        public int Id { get; set; }
        public string 狀態 { get; set; }
        public string 品名 { get; set; }
        public string 規格 { get; set; }
        public string 數量 { get; set; }
        public string 操作人員 { get; set; }
        public string 操作時間 { get; set; }
    }
}
