using System.Threading;
using System.Threading.Tasks;
using Abstractions.EventProducer.Exceptions;
using Abstractions.Events.Models;

namespace Abstractions.EventProducer
{
    /// <summary>
    /// Contract for producing an event unto an event store asynchronously
    /// </summary>
    public interface IProducerAsync
    {
        /// <summary>
        /// Appends an event unto the event store asynchronously
        /// </summary>
        /// <param name="event">the preemptively built event object</param>
        /// <param name="token">the cancellation token</param>
        /// <exception cref="ProducerException">if any operation failed during the append</exception>
        /// <returns>a task</returns>
        Task ProduceAsync(Event @event, CancellationToken token = default);
    }
}