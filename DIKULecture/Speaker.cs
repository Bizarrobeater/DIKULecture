using System;
using System.Collections.Generic;
using System.Text;

namespace DIKULecture
{
    class Speaker : Person
    {
        bool isInLecture = false;
        Lecture lecture;
        public Speaker(string name, string occupation, int age) : base(name, occupation, age)
        {
        }

        public void Speak(Lecture lecture)
        {
            if (isInLecture)
                return;

            isInLecture = true;
            this.lecture = lecture;
        }

        public void Broadcast(string information)
        {
            if (isInLecture)
                lecture.SetInformation(information);
        }
    }
}
