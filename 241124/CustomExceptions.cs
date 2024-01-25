using System.Runtime.Serialization;

namespace CustomExceptions
{
    class OwnException : System.Exception
    {
        public OwnException(SerializationInfo info, StreamingContext context) : base(info, context) {}
        public OwnException(string message, Exception? innerException) : base(message, innerException) { }
    }
}