using cqrs_example.Messages;
using NServiceBus;

namespace cqrs_example
{
    public class MessageHandler : IHandleMessages<RecordAdded>
    {
        public MessageHandler()
        {
            CurrentBus.GetCurrent().Subscribe<RecordAdded>();
        }

        public void Handle(RecordAdded message)
        {
            System.Console.WriteLine("Received a message.");
        }
    }
}