using System;

namespace CREDITProcessament.Domain.Models.ResponseModels
{
    public class GetAllProcessamentsByProcessedResponseModel
    {
        public string UserCPF { get; set; }
        public int Score { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
