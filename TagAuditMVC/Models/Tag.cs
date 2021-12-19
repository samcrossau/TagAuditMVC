using System;
using System.Collections.Generic;

namespace TagAuditMVC.Models
{
    public class Tag
    {
        public int iI { get; set; }
        public int TagId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Parameter> Parameters { get; set; }

        public Trigger Trigger { get; set; }
    }
}
