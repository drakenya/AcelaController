using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drakenya.AcelaController.Acela
{
    enum CommandType { SmartCab = 0x0a }

    class Command
    {
        private byte[] command;

        public Command(CommandType type)
        {
            this.command = new byte[] { (byte)type };
        }

        public Command(CommandType type, byte[] data)
        {
            this.command = new byte[data.Length + 1];
            this.command[0] = (byte)type;
            data.CopyTo(this.command, 1);
        }

        public byte[] RawCommand { get { return this.command; } }
    }
}
