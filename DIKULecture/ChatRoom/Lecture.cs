using System;
using System.Collections.Generic;
using System.Text;
using DIKULecture.Exceptions;

namespace DIKULecture
{
    class Lecture : ChatRoom
    {
        string information;
        Speaker speaker;
        List<Student> students = new List<Student>();

        private int numOfStudentsOnline { get { return students.Count; }}
        
        public Lecture(string name) : base(name)
        {
        }

        public void AddStudent(Student student) => students.Add(student);
        
        public void RemoveStudent(Student student) => students.Remove(student);
        
        public void AddSpeaker(Speaker speaker) => this.speaker = speaker;
        
        public void RemoveSpeaker() => this.speaker = null;

        private void SetInformation(string information)
        {
            this.information = information;
            NotifyStudents();
        }

        private void NotifyStudents()
        {
            foreach (Student student in students)
            {
                student.Listen(this.information);
            }
        }

        private bool SpeakerExist()
        {
            try
            {
                if (speaker == null)
                    throw new MissingSpeakerException(this);
                else
                    return true;


            }
            catch (MissingSpeakerException msEx)
            {
                Console.WriteLine(msEx);
                return false;
            }
        }

        public void StartLecture()
        {
            if (!SpeakerExist())
                return;

            bool speakFinished = false;
            while (!speakFinished)
            {
                SetInformation(speaker.Broadcast(out speakFinished));
            }
            EndLecture();
        }

        private void EndLecture()
        {
            speaker = null;

            foreach (Student student in students)
            {
                student.LeaveLecture();
            }

            students = new List<Student>();
        }

        public override string ToString()
        {
            return $"{GetName} - {numOfStudentsOnline} students online";
        }
    }
}
