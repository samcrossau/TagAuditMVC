using System;
namespace TagAuditMVC.Models
{
    public class Trigger
    {
        public int Id { get; set; }
        public int TriggerId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public TriggerFilter TriggerFilter { get; set; }
        public Tag Tag { get; set; }
    }
}
