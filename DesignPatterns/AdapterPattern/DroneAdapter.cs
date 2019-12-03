using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern
{
    class DroneAdapter : IDuck
    {
        private IDrone _drone;

        public DroneAdapter(IDrone drone)
        {
            this._drone = drone;
        }

        public void Fly()
        {
            this._drone.SpinRotors();
            this._drone.TakeOff();
        }

        public void Quack()
        {
            this._drone.Beep();
        }
    }
}
