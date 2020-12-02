using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    internal class BadCategoryException : Exception
    {
        public BadCategoryException()
        {
        }

        public BadCategoryException(string message) : base(message)
        {
        }

        public BadCategoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BadCategoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}