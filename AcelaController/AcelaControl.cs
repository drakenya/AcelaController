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
        Layout.TrainLayout layout;
        //Queue<Command.AcelaCommand> PendingCommands = new Queue<Command.AcelaCommand>();

        //Command.SmartCab Cab1 = new Command.SmartCab(1);

        public AcelaControlForm()
        {
            InitializeComponent();

            this.layout = new AcelaController.Layout.TrainLayout();
            this.layout.InitializeSmartCabs(1);
        }

        private void AcelaControlForm_Load(object sender, EventArgs e)
        {

        }

        private void chkCab1Brake_CheckedChanged(object sender, EventArgs e)
        {
            this.layout.GetSmartCab(0).ToggleBrake();
            //this.Cab1.ToggleBrake();
            //this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }

        private void rdoCab1Forward_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCab1Forward.Checked)
            {
                this.layout.GetSmartCab(0).ToggleDirection();
            }
            //this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }

        private void rdoCab1Reverse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCab1Reverse.Checked)
            {
                this.layout.GetSmartCab(0).ToggleDirection();
            }
            //this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }

        private void trkCab1Inertia_Scroll(object sender, EventArgs e)
        {
            this.layout.GetSmartCab(0).SetInertia((byte)trkCab1Inertia.Value);
            //this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }

        private void trkCab1Speed_Scroll(object sender, EventArgs e)
        {
            this.layout.GetSmartCab(0).SetSpeed((byte)trkCab1Speed.Value);
            //this.PendingCommands.Enqueue(this.Cab1.GenerateCommand());
        }
    }
}
