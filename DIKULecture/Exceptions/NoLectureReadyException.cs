using System;
using System.Collections.Generic;
using System.Text;

namespace DIKULecture.Exceptions
{
    class NoLectureReadyException : Exception
    {
        public NoLectureReadyException()
        {
        }

        public NoLectureReadyException(string name) 
            : base($"Speaker {name} has no speak prepared.")
        {
        }

        public NoLectureReadyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
