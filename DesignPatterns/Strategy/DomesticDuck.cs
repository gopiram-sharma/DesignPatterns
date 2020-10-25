using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class DomesticDuck
    {
        IDisplayBehaviour _db;
        IFlyBehaviour _fb;
        IQuackBehaviour _qb;

        public DomesticDuck(IDisplayBehaviour db, IFlyBehaviour fb, IQuackBehaviour qb)
        {
            _db = db;
            _fb = fb;
            _qb = qb;
        }

        public void Fly()
        {
            _fb.Fly();
        }

        public void Quack()
        {
            _qb.Quack();
        }

        public void Display()
        {
            _db.Display();
        }
    }
}
