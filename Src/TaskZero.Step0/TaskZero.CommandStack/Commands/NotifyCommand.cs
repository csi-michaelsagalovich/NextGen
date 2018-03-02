using Memento;

namespace TaskZero.CommandStack.Commands
{
    public class NotifyCommand : Command
    {
        public NotifyCommand(string connectionId = "")
        {
            SignalrConnectionId = connectionId;
        }
        public string SignalrConnectionId { get; }
    }
}