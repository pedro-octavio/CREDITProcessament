namespace CREDITProcessament.Domain.Models.RequestModels
{
    public class UpdateProcessamentRequestModel
    {
        public string UserCPF { get; set; }
        public int Score { get; set; }
        public bool IsProcessed { get; set; }
    }
}
