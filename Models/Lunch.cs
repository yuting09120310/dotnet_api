using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Lunch
    {
        public string 日期 { get; set; }
        public string 部門 { get; set; }
        public string 葷食 { get; set; }
        public string 素食飯 { get; set; }
        public string 素食麵 { get; set; }
    }
}
