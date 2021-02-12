using System;
using System.Collections.Generic;
using System.Text;

namespace DIKULecture.Exceptions
{
    class PersonNotInLectureException : Exception
    {
        public PersonNotInLectureException()
        {
        }

        public PersonNotInLectureException(Person person) 
            : base($"{person.GetType().Name} {person.GetName()} is not currently in a lecture.")
        {
        }

        public PersonNotInLectureException(string message, Exception inner) 
            : base(message, inner)
        {
        }
    }
}
