namespace CREDITProcessament.Domain.Models.ResponseModels
{
    public class GetUserByCPFResponseModel
    {
        public GetUserByCPFResponseModel(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
