using System;

namespace Abstractions.EventProducer.Exceptions
{
    public class ProducerException : ApplicationException
    {
        public ProducerException(string? message) : base(message) {}
        public ProducerException(string? message, Exception? innerException) : base(message, innerException) {}
    }
}