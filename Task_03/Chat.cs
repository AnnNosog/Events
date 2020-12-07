using System;

namespace Task_03
{
    class Chat
    {
        public event EventHandler GetMessage;
        public event EventHandler ReadMessage;
        private int senderID;
        private Message message;

        private User[] users;
        
        public Chat(int sizeChat)
        {
            users = new User[sizeChat];
        }

        public void AddUser(User user)
        {
            int count = 0;

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] == null)
                {
                    count += 1;
                    GetMessage += user.OnGetMessage;
                    ReadMessage += user.ReadingMessage;
                    users[i] = user;
                    break;
                }
            }

            if (count == 0)
            {
                throw new ArgumentException("Chat is full.");
            }
        }

        public void OnSendMessage(int userID, Message msg)
        {
            senderID = userID;
            message = msg;

            GetMessage?.Invoke(this, new UserEventArgs(users[userID], msg));
        }

        public void OnReadMessage()
        {
            ReadMessage?.Invoke(this, new UserEventArgs(users[senderID], message));
        }
    }
}
