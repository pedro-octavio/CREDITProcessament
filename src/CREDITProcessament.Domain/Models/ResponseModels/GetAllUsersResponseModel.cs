namespace CREDITProcessament.Domain.Models.ResponseModels
{
    public class GetAllUsersResponseModel
    {
        public GetAllUsersResponseModel(string cpf, string name)
        {
            CPF = cpf;
            Name = name;
        }

        public string CPF { get; set; }
        public string Name { get; set; }
    }
}
