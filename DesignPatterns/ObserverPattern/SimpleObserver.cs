using DesignPatterns.ObserverPattern.Interfaces;
using System;

namespace DesignPatterns.ObserverPattern
{
    public class SimpleObserver : Interfaces.IObserver<int>
    {
        private int _value;
        private ISubject<int> _simpleSubject;

        public SimpleObserver(ISubject<int> simpleSubject)
        {
            this._simpleSubject = simpleSubject;
            this._simpleSubject.RegisterObserver(this);
        }

        public void Update(int value)
        {
            this._value = value;
        }

        public void Display()
        {
            Console.WriteLine($"{this._value}");
        }
    }
}
