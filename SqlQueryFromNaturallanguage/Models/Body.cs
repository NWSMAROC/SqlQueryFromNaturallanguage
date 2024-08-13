namespace SqlQueryFromNaturallanguage
{
    public class Body
    {
        public string model { get; set; } = "gpt-4o-mini";
        public List<Message> messages { get; set; } = new List<Message>(); 
    }
}
