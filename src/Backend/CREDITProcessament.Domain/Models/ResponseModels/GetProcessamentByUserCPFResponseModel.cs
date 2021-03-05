using System;

namespace CREDITProcessament.Domain.Models.ResponseModels
{
    public class GetProcessamentByUserCPFResponseModel
    {
        public int Score { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
