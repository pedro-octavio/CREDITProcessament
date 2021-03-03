namespace CREDITProcessament.Domain.Models.RequestModels
{
    public class DeleteUserRequestModel
    {
        public DeleteUserRequestModel(string cpf)
        {
            CPF = cpf;
        }

        public string CPF { get; set; }
    }
}
