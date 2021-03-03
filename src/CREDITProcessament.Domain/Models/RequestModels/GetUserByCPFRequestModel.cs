namespace CREDITProcessament.Domain.Models.RequestModels
{
    public class GetUserByCPFRequestModel
    {
        public GetUserByCPFRequestModel(string cpf)
        {
            CPF = cpf;
        }

        public string CPF { get; set; }
    }
}
