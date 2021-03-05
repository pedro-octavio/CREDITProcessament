using System;

namespace CREDITProcessament.Domain.Models.ResponseModels
{
    public class GetAllProcessamentsByCreateDateResponseModel
    {
        public string UserCPF { get; set; }
        public int Score { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
