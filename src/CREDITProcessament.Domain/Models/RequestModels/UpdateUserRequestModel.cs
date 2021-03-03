namespace CREDITProcessament.Domain.Models.RequestModels
{
    public class UpdateUserRequestModel
    {
        public UpdateUserRequestModel(string cpf, string name)
        {
            CPF = cpf;
            Name = name;
        }

        public string CPF { get; set; }
        public string Name { get; set; }
    }
}
