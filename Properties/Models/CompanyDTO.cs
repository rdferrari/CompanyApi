namespace CompanyApi.Models
{
    public class CompanyDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Manager { get; set; }
        public bool? IsActive { get; set; }
    }
}