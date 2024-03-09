namespace WebShellApp.Models
{
    public class CommandHistory
    {
        public int Id { get; set; }
        public string Command { get; set; } = null!;
        public string Output { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
