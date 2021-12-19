using System;
using System.Collections.Generic;

namespace TagAuditMVC.Models
{
    public class Variable
    {
        public int Id { get; set; }
        public int VariableId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Parameter> Parameters { get; set; }
    }
}
