namespace ApiProject.Models
{
    public class Response
    {
        public int statusCode { get; set; }
        public string? statusDescription { get; set; }
        public List<Singer?>? Singer { get; set; }
        public List<Albums?>? Albums { get; set; }
    }
}
