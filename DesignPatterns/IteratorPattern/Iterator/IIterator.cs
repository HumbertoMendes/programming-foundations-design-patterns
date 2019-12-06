namespace DesignPatterns.IteratorPattern.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
