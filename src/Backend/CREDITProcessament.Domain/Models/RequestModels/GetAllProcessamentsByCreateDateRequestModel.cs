using System;

namespace CREDITProcessament.Domain.Models.RequestModels
{
    public class GetAllProcessamentsByCreateDateRequestModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
