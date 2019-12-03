using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern
{
    public class TurkeyAdapter : IDuck
    {
        public ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this._turkey = turkey;
        }

        public void Fly()
        {
            for (var i = 0; i < 5; i++)
            {
                this._turkey.Fly();
            }
        }

        public void Quack()
        {
            this._turkey.Gobble();
        }
    }
}
