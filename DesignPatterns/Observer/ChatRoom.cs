using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class ChatRoom : IChatRoom
    {
        List<IChatUser> users;
        public ChatRoom()
        {
            users = new List<IChatUser>(); 
        }
        public void Add(IChatUser user)
        {
            users.Add(user);
        }

        public void Remove(IChatUser user)
        {
            users.Remove(user);
        }

        public void Notify()
        {
            foreach (var u in users)
            {
                u.Update();
            }
        }

        public string GetMessage()
        {
            return "Message from chat room";
        }
    }
}
