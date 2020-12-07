using System;

namespace Task_03
{
    internal class Message
    {
        public string MessageText { get; private set; }
        public DateTime Date { get; private set; }

        public Message(string mess)
        {
            MessageText = mess;
            Date = DateTime.Now;
        }
    }
}
