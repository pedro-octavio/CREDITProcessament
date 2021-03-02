namespace CREDITProcessament.Data.Models
{
    public class UserModel
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public ProcessamentModel Processament { get; set; }
    }
}
