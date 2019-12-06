using DesignPatterns.IteratorPattern.Aggregator;
using DesignPatterns.IteratorPattern.Iterator;

namespace DesignPatterns.IteratorPattern
{
    public class Cafe
    {
        private IMenu<MenuItem> _dinerMenu;

        public Cafe(IMenu<MenuItem> dinerMenu)
        {
            this._dinerMenu = dinerMenu;
        }

        public void printMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = iterator.Next();
            }
        }
    }
}
