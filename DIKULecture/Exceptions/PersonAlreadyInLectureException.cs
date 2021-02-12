using System;

namespace DIKULecture.Exceptions
{
    class PersonAlreadyInLectureException : Exception
    {

        public PersonAlreadyInLectureException()
        {
        }

        public PersonAlreadyInLectureException(Person person, string lectureName) 
            : base($"{person.GetType().Name} {person.GetName()} is already in a lecture called {lectureName}")

        {
        }

        public PersonAlreadyInLectureException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
