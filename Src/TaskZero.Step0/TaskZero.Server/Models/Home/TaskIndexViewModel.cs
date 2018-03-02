using System.Collections.Generic;
using TaskZero.ReadStack.ReadModel;
namespace TaskZero.Server.Models.Home
{
    public class TaskIndexViewModel : ViewModelBase
    {
        public TaskIndexViewModel()
        {
            Tasks = new List<PendingTask>();
        }
        public IList<PendingTask> Tasks { get; set; }
    }
}