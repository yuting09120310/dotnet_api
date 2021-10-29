using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class ChangLineWork
    {
        public string 線別 { get; set; }
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public int 批量 { get; set; }
        public string 面板 { get; set; }
        public string 錫膏型號 { get; set; }
        public string 錫膏編號 { get; set; }
        public DateTime 開封日期 { get; set; }
        public string 鋼板編號 { get; set; }
        public string 鋼板厚度 { get; set; }
        public string 鋼板執行 { get; set; }
        public string 頂pin確認 { get; set; }
        public string Cpk { get; set; }
        public string Bom核對 { get; set; }
        public string 首件執行 { get; set; }
        public string 首件確認 { get; set; }
        public string 極性確認 { get; set; }
        public string 印刷確認 { get; set; }
        public string 爐溫 { get; set; }
        public string 印刷機 { get; set; }
        public string XRay { get; set; }
        public string 頂針 { get; set; }
        public string 送板機 { get; set; }
        public string 收板機 { get; set; }
        public string 空板 { get; set; }
        public string 吸嘴 { get; set; }
        public string 裝著點 { get; set; }
        public string Sop參數 { get; set; }
        public string 氮氣 { get; set; }
        public string 點膠 { get; set; }
        public string 線長 { get; set; }
        public string 隨線 { get; set; }
        public DateTime 時間 { get; set; }
    }
}
