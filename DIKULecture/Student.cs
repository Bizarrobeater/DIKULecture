using System;
using System.Collections.Generic;
using System.Text;

namespace DIKULecture
{
    class Student : Person
    {
        bool isInLecture = false;
        Lecture lecture;
        string information;
        public Student(string name, string occupation, int age) : base(name, occupation, age)
        {
        }

        public void Join(Lecture newLecture)
        {
            if (isInLecture)
                return;

            lecture = newLecture;
            lecture.AddStudent();

            isInLecture = true;
        }

        public void Listen()
        {
            if (!isInLecture)
                return;

            information = lecture.GetInformation();

        }
    }
}
