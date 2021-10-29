using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class ChinTekMail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MailAddress { get; set; }
        public string NickName { get; set; }
    }
}
