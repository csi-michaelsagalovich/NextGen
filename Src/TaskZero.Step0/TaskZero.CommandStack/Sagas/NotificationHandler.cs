using Memento.Messaging.Postie;
using TaskZero.CommandStack.Commands;
using TaskZero.Shared;
namespace TaskZero.CommandStack.Sagas
{
    public class NotificationHandler :
    IHandleMessages<AddNewTaskNotifyCommand>
    {
        public void Handle(AddNewTaskNotifyCommand message)
        {
            // Notify back
            var hub = new TaskZeroHub(message.SignalrConnectionId);
            hub.NotifyResultOfAddNewTask(message.TaskId, message.Title);
        }
    }
}