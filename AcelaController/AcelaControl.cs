using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drakenya.AcelaController
{
    public partial class AcelaControlForm : Form
    {
        Queue<Command.AcelaCommand> PendingCommands = new Queue<Command.AcelaCommand>();

        Command.SmartCab Cab1 = new Command.SmartCab(1);

        public AcelaControlForm()
        {
            InitializeComponent();
        }

        private void AcelaControlForm_Load(object sender, EventArgs e)
        {

        }

        private void chkCab1Brake_CheckedChanged(object sender, EventArgs e)
        {
            this.Cab1.ToggleBrake();
            this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }

        private void rdoCab1Forward_CheckedChanged(object sender, EventArgs e)
        {
            this.Cab1.ToggleDirection();
            this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }

        private void rdoCab1Reverse_CheckedChanged(object sender, EventArgs e)
        {
            this.Cab1.ToggleDirection();
            this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }

        private void trkCab1Inertia_Scroll(object sender, EventArgs e)
        {
            this.Cab1.SetInertia((byte)trkCab1Inertia.Value);
            this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }

        private void trkCab1Speed_Scroll(object sender, EventArgs e)
        {
            this.Cab1.SetSpeed((byte)trkCab1Speed.Value);
            this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }
    }
}
