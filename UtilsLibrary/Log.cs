using System;
namespace UtilsLibrary
{
    public sealed class Log
    {
        public string OriginatedFrom { get; set; }
        public int Counter {get;set;}
        internal DateTime TimeStamp { get; set; }
        public Severity Severity { get; set; }
        public string Message { get; set; }

    }

    public enum Severity
    {
        Warning = 0,
        Error = 1,
        Success = 2
    }
}