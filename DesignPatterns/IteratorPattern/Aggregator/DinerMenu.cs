using System;
using DesignPatterns.IteratorPattern.Iterator;

namespace DesignPatterns.IteratorPattern.Aggregator
{
    public class DinerMenu : IMenu<MenuItem>
    {
        public IIterator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator(new MenuItem[] { });
        }
    }
}
