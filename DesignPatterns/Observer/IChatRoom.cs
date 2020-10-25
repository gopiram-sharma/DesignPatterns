using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public interface IChatRoom
    {
        void Add(IChatUser observable);
        void Remove(IChatUser observable);
        void Notify();
        string GetMessage();
    }
}
