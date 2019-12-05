namespace DesignPatterns.ObserverPattern.Interfaces
{
    public interface IObserver<T>
    {
        void Update(T value);
    }
}
