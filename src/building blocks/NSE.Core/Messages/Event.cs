using MediatR;

namespace NSE.Core.Messages
{
    public class Event :Message, INotification
    {
        public DateTime Timestemp { get;private set; }

        protected Event()
        {
            Timestemp = DateTime.Now;
        }
    }
}