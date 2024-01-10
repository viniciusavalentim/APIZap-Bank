namespace API_ZapBank.Models
{
    public class ServiceResponse<T>//"T" - Signifa que vai receber dados genericos
    {
        public T? Data { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool Sucess { get; set; } = true;

    }
}
