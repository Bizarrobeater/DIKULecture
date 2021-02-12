using System;
using System.Collections.Generic;
using System.Text;

namespace DIKULecture.Exceptions
{
    class MissingSpeakerException : Exception
    {

        public MissingSpeakerException()
        {
        }

        public MissingSpeakerException(Lecture lecture)
            : base($"No speaker at lecture - {lecture.GetName}.")
        {
        }

        public MissingSpeakerException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
