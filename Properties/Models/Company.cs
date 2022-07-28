namespace CompanyApi.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Manager { get; set; }
        public bool? IsActive { get; set; }
        public string? Secret { get; set; }
    }
}