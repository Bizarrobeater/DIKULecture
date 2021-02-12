using System;
using System.Collections.Generic;
using System.Text;

namespace DIKULecture.Exceptions
{
    class SpeakIsFinishedException : Exception
    {
        public SpeakIsFinishedException()
        {
        }

        public SpeakIsFinishedException(string name)
            : base($"Speaker {name} has no more information to give.")
        {
        }

        public SpeakIsFinishedException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
