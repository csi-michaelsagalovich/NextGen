using Memento.Messaging.Postie;

namespace TaskZero.Server.Application
{
    public class ApplicationServiceBase
    {
        public ApplicationServiceBase(IBus bus)
        {
            Bus = bus;
        }
        public IBus Bus { get; }
    }
}