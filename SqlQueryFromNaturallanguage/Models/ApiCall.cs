namespace SqlQueryFromNaturallanguage.Models
{
    public class ApiCall
    {
        public string apikey { get; set; } = string.Empty;
        public string baseAddress { get; set; } = string.Empty;
        public string request { get; set; } = string.Empty;
        public Body body { get; set; } = new Body();

    }
}
