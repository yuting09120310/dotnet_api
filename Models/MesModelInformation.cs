using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class MesModelInformation
    {
        public string 機種 { get; set; }
        public int 流程代碼 { get; set; }
        public string 序號種類 { get; set; }
        public string 建立者 { get; set; }
        public string 建立時間 { get; set; }
    }
}
