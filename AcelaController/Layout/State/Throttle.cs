using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drakenya.AcelaController.State
{
    public class Throttle
    {
        private byte id;
        private byte speed;
        private byte direction;
        private byte brake;
        private byte inertia;
        private byte idleVoltage;

        public Throttle(byte id, byte speed, byte direction, byte brake, byte inertia, byte idleVoltage)
        {
            this.id = id;
            this.speed = speed;
            this.direction = direction;
            this.brake = brake;
            this.inertia = inertia;
            this.idleVoltage = idleVoltage;
        }

        public byte Id {  get { return this.id; } }
        public byte Speed { get { return this.speed; } }
        public byte Direction { get { return this.direction; } }
        public byte Brake { get { return this.brake; } }
        public byte Inertia { get { return this.inertia; } }
        public byte IdleVoltage { get { return this.idleVoltage; } }
    }
}
