using System;

namespace CREDITProcessament.Domain.Models.RequestModels
{
    public class AddProcessamentRequestModel
    {
        public AddProcessamentRequestModel(string userCPF, int score)
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);
            UserCPF = userCPF;
            Score = score;
            IsProcessed = false;
            CreateDate = DateTime.Now;
        }

        public string Id { get; private set; }
        public string UserCPF { get; set; }
        public int Score { get; set; }
        public bool IsProcessed { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}
