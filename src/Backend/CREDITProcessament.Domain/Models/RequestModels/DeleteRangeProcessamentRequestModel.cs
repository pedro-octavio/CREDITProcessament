using System.Collections.Generic;

namespace CREDITProcessament.Domain.Models.RequestModels
{
    public class DeleteRangeProcessamentRequestModel
    {
        public IList<string> CPFs { get; set; }
    }
}
