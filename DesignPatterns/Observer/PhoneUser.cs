using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class PhoneUser : IChatUser
    {
        IChatRoom chatRoom;
        public PhoneUser(IChatRoom room)
        {
            chatRoom = room;
        }
        public void Update()
        {
            Console.WriteLine("Phone user got an update: " + chatRoom.GetMessage());
        }
    }
}
