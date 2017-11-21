using System;

namespace Drakenya.AcelaController.Command
{
    public class SmartCab : IAcelaCommand
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

        public SmartCab(byte index)
        {
            this.index = index;
            this.speed = 0;
            this.direction = (byte)Direction.Forward;
            this.brake = (byte)BrakeStatus.On;
            this.inertia = 0;
            this.idleVoltage = (byte)IdleVoltage.Applied;
        }

        public AcelaCommand GenerateCommand()
        {
            byte[] commandData =
            {
                0,
                this.index,
                this.speed,
                (byte)(this.inertia + (this.brake * 8) + (this.direction * 16) + (this.idleVoltage * 32))
            };
            return new AcelaCommand(CommandType.Throttle, commandData);
        }

        public void ToggleBrake()
        {
            this.brake = (this.brake == (byte)BrakeStatus.On) ? (byte)BrakeStatus.Off : (byte)BrakeStatus.On;
        }

        public void ToggleDirection()
        {
            this.direction = (this.direction == (byte)Direction.Forward) ? (byte)Direction.Reverse : (byte)Direction.Forward;
        }

        public void SetInertia(byte inertia)
        {
            if (inertia < InertiaMin) inertia = InertiaMin;
            if (inertia > InertiaMax) inertia = InertiaMax;

            this.inertia = inertia;
        }

        public void SetSpeed(byte speed)
        {
            if (speed < SpeedMin) speed = SpeedMin;
            if (speed > SpeedMax) speed = SpeedMax;

            this.speed = speed;
        }
    }
}