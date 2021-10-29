using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class AccountResign
    {
        public long? Id { get; set; }
        public string Dept { get; set; }
        public string Name { get; set; }
        public string Resigndate { get; set; }
        public string Applydate { get; set; }
        public string ItCheck { get; set; }
        public string AccountingCheck { get; set; }
        public string Status { get; set; }
    }
}
