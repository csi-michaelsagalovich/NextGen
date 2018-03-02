using System;

namespace TaskZero.CommandStack.Commands
{
    public class AddNewTaskNotifyCommand : NotifyCommand
    {
        public AddNewTaskNotifyCommand(string connectionId)
        : base(connectionId)
        {
        }
        public Guid TaskId { get; set; }
        public string Title { get; set; }
    }
}   