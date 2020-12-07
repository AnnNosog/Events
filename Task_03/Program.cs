using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat(10);

            chat.AddUser(new User("TestUser"));
            chat.AddUser(new User("TestUser2"));
            chat.AddUser(new User("TestUser3"));
            chat.AddUser(new User("TestUser4"));

            chat.OnSendMessage(1, new Message("Test2oy 23wgwoy 2qy8"));
            chat.OnReadMessage();


            Console.ReadKey();
        }
    }
}
