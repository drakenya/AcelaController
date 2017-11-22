using System;
using System.Collections.Generic;
using Drakenya.AcelaController.State;

namespace Drakenya.AcelaController.Layout.Control
{
    public class SmartCab : IObservable<Throttle>
    {
        const byte InertiaMin = 0;
        const byte InertiaMax = 7;
        const byte SpeedMin = 0;
        const byte SpeedMax = 100;

        enum Direction { Forward, Reverse };
        enum BrakeStatus { Off, On };
        enum IdleVoltage { NotApplied, Applied };

        byte index;
        byte speed;
        byte direction;
        byte brake;
        byte inertia;
        byte idleVoltage;

        List<IObserver<Throttle>> observers;

        public SmartCab(byte index)
        {
            this.observers = new List<IObserver<Throttle>>();

            this.index = index;
            this.speed = 0;
            this.direction = (byte)Direction.Forward;
            this.brake = (byte)BrakeStatus.On;
            this.inertia = 0;
            this.idleVoltage = (byte)IdleVoltage.Applied;
        }

        public IDisposable Subscribe(IObserver<Throttle> observer)
        {
            if (! observers.Contains(observer))
                observers.Add(observer);

            return new SmartCabUnsubscriber(observers, observer);
        }

        //public AcelaCommand GenerateCommand()
        //{
        //    byte[] commandData =
        //    {
        //        0,
        //        this.index,
        //        this.speed,
        //        (byte)(this.inertia + (this.brake * 8) + (this.direction * 16) + (this.idleVoltage * 32))
        //    };
        //    return new AcelaCommand(CommandType.Throttle, commandData);
        //}

        public void ToggleBrake()
        {
            this.brake = (this.brake == (byte)BrakeStatus.On) ? (byte)BrakeStatus.Off : (byte)BrakeStatus.On;
            this.SignalChange();
        }

        public void ToggleDirection()
        {
            this.direction = (this.direction == (byte)Direction.Forward) ? (byte)Direction.Reverse : (byte)Direction.Forward;
            this.SignalChange();
        }

        public void SetInertia(byte inertia)
        {
            if (inertia < InertiaMin) inertia = InertiaMin;
            if (inertia > InertiaMax) inertia = InertiaMax;

            if (this.inertia != inertia)
            {
                this.inertia = inertia;
                this.SignalChange();
            }
        }

        public void SetSpeed(byte speed)
        {
            if (speed < SpeedMin) speed = SpeedMin;
            if (speed > SpeedMax) speed = SpeedMax;

            if (this.speed != speed)
            {
                this.speed = speed;
                this.SignalChange();
            }
        }

        protected void SignalChange()
        {
            Throttle throttle = new Throttle(this.index, this.speed, this.direction, this.brake, this.inertia, this.idleVoltage);

            foreach (var observer in this.observers)
                observer.OnNext(throttle);
        }
    }

    class SmartCabUnsubscriber : IDisposable
    {
       private List<IObserver<Throttle>> _observers;
       private IObserver<Throttle> _observer;

       public SmartCabUnsubscriber(List<IObserver<Throttle>> observers, IObserver<Throttle> observer)
       {
          this._observers = observers;
          this._observer = observer;
       }

       public void Dispose() 
       {
          if (! (_observer == null)) _observers.Remove(_observer);
       }
    }
}