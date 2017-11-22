using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drakenya.AcelaController.State;

namespace Drakenya.AcelaController.Acela
{
    class AcelaConnector : IObserver<Throttle>
    {
        public virtual void Subscribe(IObservable<Throttle> provider)
        {
            provider.Subscribe(this);
        }

        public virtual void OnNext(Throttle throttle)
        {
            byte[] commandData =
            {
                0,
                throttle.Id,
                throttle.Speed,
                (byte)(throttle.Inertia + (throttle.Brake * 8) + (throttle.Direction * 16) + (throttle.IdleVoltage * 32))
            };
            Command command = new Command(CommandType.SmartCab, commandData);
            this.SendCommand(command);
        }

        public virtual void OnError(Exception exception)
        {

        }

        public virtual void OnCompleted()
        {

        }

        protected void SendCommand(Command command)
        {
            string hexCommand = BitConverter.ToString(command.RawCommand);
            System.Diagnostics.Debug.WriteLine("Sending Command: " + hexCommand);
        }
    }
}
