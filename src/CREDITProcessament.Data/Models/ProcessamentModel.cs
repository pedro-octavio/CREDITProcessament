using System;

namespace CREDITProcessament.Data.Models
{
    public class ProcessamentModel
    {
        public string Id { get; set; }
        public string UserCPF { get; set; }
        public int Score { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime LastProcessedDate { get; set; }
    }
}
