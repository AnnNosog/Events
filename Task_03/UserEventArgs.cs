using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class UserEventArgs : EventArgs
    {
        public User Sender { get; set; }
        public Message Message { get; set; }

        public UserEventArgs(User sender, Message mes)
        {
            Sender = sender;
            Message = mes;
        }
    }
}
