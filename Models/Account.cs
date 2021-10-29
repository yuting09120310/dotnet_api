using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Account
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Deptname { get; set; }
        public string Idenable { get; set; }
        public string Appdate { get; set; }
        public string Sysmanager { get; set; }
        public long NewId { get; set; }
        public string ItCheck { get; set; }
        public string AccountingCheck { get; set; }
        public string 班別 { get; set; }
    }
}
