using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class LaptopUser : IChatUser
    {
        IChatRoom chatRoom;
        public LaptopUser(IChatRoom room)
        {
            chatRoom = room;
        }
        public void Update()
        {
            Console.WriteLine("Laptop user got an update: " + chatRoom.GetMessage());
        }
    }
}
