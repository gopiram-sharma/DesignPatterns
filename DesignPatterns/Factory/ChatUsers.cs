using DesignPatterns.Observer;

namespace DesignPatterns.Factory
{
    public static class ChatUsers
    {
        public static void CreateUsers()
        {
            IChatRoom room = new ChatRoom();

            IChatUser user1 = new PhoneUser(room);
            IChatUser user2 = new LaptopUser(room);
            room.Add(user1);
            room.Add(user2);
            room.Notify();
        }
    }
}
