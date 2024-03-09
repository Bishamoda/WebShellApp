using WebShellApp.Models;

namespace WebShellApp.BL
{
    public interface IHistory
    {
        void Add(string command, string output);
        List<CommandHistory> ShowHistory(int page);
    }
}
