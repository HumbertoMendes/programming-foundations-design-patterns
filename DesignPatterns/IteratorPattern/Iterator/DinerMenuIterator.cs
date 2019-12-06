namespace DesignPatterns.IteratorPattern.Iterator
{
    public class DinerMenuIterator : IIterator<MenuItem>
    {
        private MenuItem[] _menuItems;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            this._menuItems = menuItems;
        }

        public bool HasNext()
        {
            return this._menuItems.Length < _position;
        }

        public MenuItem Next()
        {
            return this._menuItems[_position++];
        }
    }
}
