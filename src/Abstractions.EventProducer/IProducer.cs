using Abstractions.EventProducer.Exceptions;
using Abstractions.Events.Models;

namespace Abstractions.EventProducer
{
    /// <summary>
    /// Contract for producing an event unto an event store
    /// </summary>
    public interface IProducer
    {
        /// <summary>
        /// Appends an event unto the event store
        /// </summary>
        /// <param name="event">the preemptively built event object</param>
        /// <exception cref="ProducerException">if any operation failed during the append</exception>
        void Produce(Event @event);
    }
}