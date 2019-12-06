using DesignPatterns.IteratorPattern.Iterator;

namespace DesignPatterns.IteratorPattern.Aggregator
{
    public interface IMenu<T>
    {
        IIterator<T> CreateIterator();
    }
}
