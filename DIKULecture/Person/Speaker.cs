using System;
using System.Collections.Generic;
using DIKULecture.Exceptions;

namespace DIKULecture
{
    class Speaker : Person
    {
        bool isInLecture = false;
        string lectureName;

        Queue<string> information;
        public Speaker(string name, string occupation, int age) : base(name, occupation, age)
        {
        }

        private void LeaveLecture()
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

        private void CreateSpeak()
        {
            information = new Queue<string>();
        }

        // adds new information to the queue, creates the queue if it does not exist.
        public void AddToSpeak(string information)
        {
            if (this.information == null)
                CreateSpeak();

            this.information.Enqueue(information);
        }

        // Takes an Array of string, and either adds it to the Queue, or if one does not exist, creates a new one based on it
        public void AddToSpeak(string[] information)
        {
            if (this.information == null)
                CreateSpeak();
            
            foreach (string piece in information)
            {
                this.information.Enqueue(piece);
            }
        }

        // Overload for ICollections
        public void AddToSpeak(ICollection<string> information)
        {
            AddToSpeak((string[])information);
        }

        // Overload for IEnumerable
        public void AddToSpeak(IEnumerable<string> information)
        {
            AddToSpeak((string[])information);
        }



        public void Speak(Lecture lecture)
        {
            try
            {
                if (!isInLecture)
                {
                    lecture.AddSpeaker(this);
                    isInLecture = true;
                    lectureName = lecture.GetName;
                }
                else
                {
                    throw new PersonAlreadyInLectureException(this, lectureName);
                }       
            }
            catch (PersonAlreadyInLectureException paEx)
            {
                Console.WriteLine(paEx.Message);
            }
        }

        public string Broadcast(out bool speachFinished)
        {
            speachFinished = false;
            try
            {
                if (!isInLecture)
                    throw new PersonNotInLectureException(this);

                else if (information != null)
                    throw new NoLectureReadyException(name);

                else if (information.Count == 0)
                {
                    LeaveLecture();
                    speachFinished = true;
                }
                    

                // Broadcast information to the lecture, if the speaker is in a lecture,
                // the speak exist,
                // and the speak has not been exhausted
                else
                    return information.Dequeue();
            }

            catch (PersonNotInLectureException pnEx)
            {
                Console.WriteLine(pnEx.Message);
            }
                
            catch (NoLectureReadyException nlEx)
            {
                Console.WriteLine(nlEx.Message);
            }

            return "";
        }
    }
}
