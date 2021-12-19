using System;
using System.Collections.Generic;

namespace TagAuditMVC.Models
{
    public class TriggerFilter
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Parameter> Parameters { get; set; }
    }
}
