using System;

namespace Drakenya.AcelaController.Command
{
    public enum CommandType { Throttle = 0x0a };

    public class AcelaCommand
    {
        protected byte[] command;

        public AcelaCommand(CommandType type)
        {
            this.command = new byte[] { (byte)type };
        }

        public AcelaCommand(CommandType type, byte[] commandData)
        {
            this.command = new byte[commandData.Length + 1];
            this.command[0] = (byte)type;
            commandData.CopyTo(this.command, 1);
        }

        public byte[] GetCommand()
        {
            return this.command;
        }
    }
}