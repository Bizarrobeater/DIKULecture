using System;
using System.Collections.Generic;
using System.Text;

namespace DIKULecture
{
    class ChatRoom
    {
        private string name;

        public string GetName() => name;
        public void SetName(string name) => this.name = name;
        public ChatRoom(string name)
        {
            this.name = name;
        }
    }
}
