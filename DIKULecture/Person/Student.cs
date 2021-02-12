using System;
using System.Collections.Generic;
using DIKULecture.Exceptions;

namespace DIKULecture
{
    class Student : Person
    {
        bool isInLecture = false;
        string lectureName;
        Dictionary<string, List<string>> information = new Dictionary<string, List<string>>();
        public Student(string name, string occupation, int age) : base(name, occupation, age)
        {
        }

        public void LeaveLecture()
        {
            try
            {
                if (isInLecture)
                {
                    isInLecture = false;
                    lectureName = "";
                }
                else
                    throw new PersonNotInLectureException(this);
            }
            catch (PersonNotInLectureException pnEx)
            {
                Console.WriteLine(pnEx.Message);
            }
        }

        public void Join(Lecture newLecture)
        {
            try
            {
                if (!isInLecture)
                {
                    
                    newLecture.AddStudent(this);
                    lectureName = newLecture.GetName;
                    isInLecture = true;
                }
                else
                    throw new PersonAlreadyInLectureException(this, lectureName);
            }
            catch (PersonAlreadyInLectureException plEx)
            {
                Console.WriteLine(plEx.Message);
            }
        }

        public void Listen(string information)
        {
            if (information != "")
                this.information[lectureName].Add(information);
        }
    }
}
