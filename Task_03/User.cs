using System;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;

namespace Task_03
{
    class User
    {
        public string Name { get; private set; }

        public User(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Uncorrect name");
            }

            Name = name;
        }

        public void SendingMessage(Message mess)
        {
            Console.WriteLine(mess.MessageText, mess.Date);
        }

        public void OnGetMessage(object obj, EventArgs ea)
        {
            UserEventArgs userEventArgs = ea as UserEventArgs;

            if (userEventArgs.Sender.Name == Name) return; // сам отправитель не получает сообщения

            Console.Write($"{userEventArgs.Message.Date}: ");
            Console.WriteLine($"User {Name} receive message from {userEventArgs.Sender.Name}");
            Console.WriteLine(userEventArgs.Message.MessageText);
        }

        public void ReadingMessage(object obj, EventArgs ea)
        {
            UserEventArgs userEventArgs = ea as UserEventArgs;

            if (userEventArgs.Sender.Name == Name) return;

            Console.Write($"{DateTime.Now}: ");
            Console.WriteLine($"User {Name} read message from {userEventArgs.Sender.Name}");
            //Console.WriteLine(userEventArgs.Message.MessageText);
        }

    }
}
