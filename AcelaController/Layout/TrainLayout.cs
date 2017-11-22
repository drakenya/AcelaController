using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drakenya.AcelaController.Acela;

namespace Drakenya.AcelaController.Layout
{
    class TrainLayout
    {
        AcelaConnector connector;
        Control.SmartCab[] SmartCabs;

        public TrainLayout()
        {
            this.connector = new AcelaConnector();
        }

        public void InitializeSmartCabs(byte quantity)
        {
            this.SmartCabs = new Control.SmartCab[quantity];
            for (byte index = 0; index < quantity; index++)
            {
                this.SmartCabs[index] = new Control.SmartCab(index);
                this.connector.Subscribe(this.SmartCabs[index]);
            }
        }

        public Control.SmartCab GetSmartCab(byte index)
        {
            return this.SmartCabs[index];
        }
    }
}
