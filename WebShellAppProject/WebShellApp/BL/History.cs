using WebShellApp.Models;

namespace WebShellApp.BL
{
    public class History : IHistory
    {
        public void Add(string command, string output)
        {
            using (var db = new ShellWebHistoryDbContext())
            {
                db.CommandHistory.Add(
                    new CommandHistory()
                    {
                        Command = command,
                        Output = output,
                        CreatedDate = DateTime.Now
                    }
                );

                db.SaveChanges();
            }
        }

        public List<CommandHistory> ShowHistory(int page)
        {
            int pageSize = 10;
            using (var db = new ShellWebHistoryDbContext())
            {
                return db.CommandHistory.Skip(page * pageSize).Take(pageSize).ToList();
            }
        }
    }
}
