namespace CREDITProcessament.Domain.Models.RequestModels
{
    public class AddUserRequestModel
    {
        public AddUserRequestModel(string cpf, string name)
        {
            CPF = cpf;
            Name = name;
        }

        public string CPF { get; set; }
        public string Name { get; set; }
    }
}
