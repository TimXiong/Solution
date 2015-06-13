using System;
using System.Runtime.Serialization;

namespace TimXiong.ScannerDriver
{
    [Serializable]
    public class ScannerDriverException : Exception
    {
        public ScannerDriverException()
        { }

        public ScannerDriverException(string message)
            : base(message)
        { }

        public ScannerDriverException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public ScannerDriverException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
