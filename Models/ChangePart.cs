using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class ChangePart
    {
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 主料料號 { get; set; }
        public string 替代用料料號 { get; set; }
        public string 變更人 { get; set; }
        public string 變更時間 { get; set; }
    }
}
