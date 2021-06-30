using System;
using System.Collections.Generic;
using Abstractions.EventProducer.Exceptions;
using Abstractions.Events;

namespace Abstractions.EventProducer
{
    /// <summary>
    /// Contract for producing an event unto an event store
    /// </summary>
    public interface IProducer : IDisposable
    {
        /// <summary>
        /// Appends an event unto the event store
        /// </summary>
        /// <param name="event">the preemptively built event object</param>
        /// <exception cref="ProducerException">if any operation failed during the append</exception>
        void Produce(Event @event);

        /// <summary>
        /// Appends all the events (in order) unto the event store
        /// </summary>
        /// <param name="events">the preemptively built ordered list of event object</param>
        /// <exception cref="ProducerException">if any operation failed during the append</exception>
        void ProduceMany(IList<Event> events);
    }
}