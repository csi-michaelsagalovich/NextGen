using System.Data.Entity;
using TaskZero.ReadStack.ReadModel;
namespace TaskZero.ReadStack.Repositories
{
    public class TaskContext : DbContext
    {
        public TaskContext()
        : base("MfxDemoDb")
        {
        }
        public DbSet<PendingTask> PendingTasks { get; set; }
    }
}