using System;
using System.Collections.Generic;
using System.Text;

namespace DIKULecture
{
    class Lecture : ChatRoom
    {
        int numOfStudentsOnline = 0;
        string information;
        public Lecture(string name) : base(name)
        {
        }

        public void AddStudent() => numOfStudentsOnline = numOfStudentsOnline + 1;
        public void RemoveStudent() => numOfStudentsOnline = numOfStudentsOnline - 1;

        public void SetInformation(string information) => this.information = information;
        public string GetInformation() => information;

        public override string ToString()
        {
            return $"{GetName()} - {numOfStudentsOnline} students online";
        }
    }
}
