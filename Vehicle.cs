using System;

namespace FacadePattern
{
    class Vehicle
    {
        
        public enum TruckType { Command, Medic, Guntruck, Radio, Retrans, SpecialForces };

        // The possible radio systems for each truck.
        private RT1523 radioA;
        private RT1523 radioB;
        private ANPRC117 satRadio;
        private FBCB2 bft;

        // The transmit and recive frequencies. The Radios do technically take
        // both of these but on the real radio it is an extra step to set them
        // differntly.
        private int txFreq_medic;
        private int rxFreq_medic;
        private int txFreq_command;
        private int rxFreq_command;
        private int txFreq_ops;
        private int rxFreq_ops;
        private int txFreq_sat;
        private int rxFreq_sat;
        private int txFreq_special;
        private int rxFreq_special;

        private string routeOverlay;

        string truckName;
        private TruckType truckType;

        // Setup the vehicle based on the type of truck it is. Every truck is
        // required to have a name.
        public Vehicle(TruckType truckType, string truckName)
        {

            this.truckName = truckName;
            this.truckType = truckType;

            txFreq_medic = 40;
            rxFreq_medic = 40;
            txFreq_command = 45;
            rxFreq_command = 45;
            txFreq_sat = 300000;
            rxFreq_sat = 350000;
            txFreq_special = 50;
            rxFreq_special = 50;
            txFreq_ops = 55;
            rxFreq_ops = 55;
            
            RadiosInTruckByType();

        }
        
        // Actually set the individual radios.
        public void SetupRadios()
        {
            switch (truckType)
            {
                case TruckType.Command:
                case TruckType.Radio:
                    SetupCommandTruckRadios();
                    break;
                case TruckType.Medic:
                    SetupMedicTruckRadios();
                    break;
                case TruckType.Guntruck:
                    SetupGuntruckRadios();
                    break;
                case TruckType.Retrans:
                    SetupRetrans();
                    break;
                case TruckType.SpecialForces:
                    SetupSpecialForces();
                    break;
            }

            bft.Overlays = routeOverlay;
        }

        // Getter Setter
        public string Name
        {
            get { return truckName; }
            set { truckName = value; }
        }

        // This is for changing the channel without attempting to change the 
        // channel of a radio that is not there.
        public void SetChannel(Radio.Channel ch)
        {

            switch (truckType)
            {
                case TruckType.Medic:
                    radioA.CurrentChannel = ch;
                    break;
                case TruckType.Guntruck:
                case TruckType.Command:
                case TruckType.Retrans:
                    radioA.CurrentChannel = ch;
                    radioB.CurrentChannel = ch;
                    break;
                case TruckType.Radio:
                case TruckType.SpecialForces:
                    radioA.CurrentChannel = ch;
                    radioB.CurrentChannel = ch;
                    satRadio.CurrentChannel = ch;
                    break;
            }
            
        }

        // Getter Setter
        public string RouteOverlay
        {
            get { return routeOverlay; }
            set { routeOverlay = value; }
        }

        // This displays all of the neccessary information about the radios on
        // the truck and the truck itself.
        public override string ToString()
        {

            string retVal;

            retVal = truckName + "\n\n";

            switch (truckType)
            {
                case TruckType.Medic:
                    retVal += "Radio A\n" + radioA.ToString() + "\n";
                    retVal += "FBCB2\n" + bft.ToString() + "\n";
                    break;
                case TruckType.Guntruck:
                case TruckType.Command:
                case TruckType.Retrans:
                    retVal += "Radio A\n" + radioA.ToString() + "\n";
                    retVal += "Radio B\n" + radioB.ToString() + "\n";
                    retVal += "FBCB2\n" + bft.ToString() + "\n";
                    break;
                case TruckType.Radio:
                case TruckType.SpecialForces:
                    retVal += "Radio A\n" + radioA.ToString() + "\n";
                    retVal += "Radio B\n" + radioB.ToString() + "\n";
                    retVal += "Satalite\n" + satRadio.ToString() + "\n";
                    retVal += "FBCB2\n" + bft.ToString() + "\n";
                    break;
            }

            retVal.Replace("\n", Environment.NewLine);
            return retVal;
        }

        // Settings for the radios on the command truck.
        private void SetupCommandTruckRadios()
        {
            
            // radioA
            radioA.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioA.CurrentMode = RT1523.Mode.PT;
            // CH1
            radioA.CurrentChannel = RT1523.Channel.CH1;
            radioA.Freq_tx = txFreq_command;
            radioA.Freq_rx = rxFreq_command;
            // CH2
            radioA.CurrentChannel = RT1523.Channel.CH2;
            radioA.Freq_tx = txFreq_ops;
            radioA.Freq_rx = rxFreq_ops;
            // CH3
            radioA.CurrentChannel = RT1523.Channel.CH3;
            radioA.Freq_tx = txFreq_medic;
            radioA.Freq_rx = rxFreq_medic;

            // radioB
            radioB.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioB.CurrentMode = RT1523.Mode.FHM;
            // CH1
            radioB.CurrentChannel = RT1523.Channel.CH1;
            radioB.Freq_tx = txFreq_special;
            radioB.Freq_rx = rxFreq_special;

            // BFT
            bft.Overlays = routeOverlay;

        }

        // Settings for the radios on the radio truck.
        private void SetupGuntruckRadios()
        {

            // radioA
            radioA.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioA.CurrentMode = RT1523.Mode.PT;
            // CH1
            radioA.CurrentChannel = RT1523.Channel.CH1;
            radioA.Freq_tx = txFreq_ops;
            radioA.Freq_rx = rxFreq_ops;
            // CH2
            radioA.CurrentChannel = RT1523.Channel.CH2;
            radioA.Freq_tx = txFreq_medic;
            radioA.Freq_rx = rxFreq_medic;

            // radioB
            radioB.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioB.CurrentMode = RT1523.Mode.PT;
            // CH1
            radioB.CurrentChannel = RT1523.Channel.CH1;
            radioB.Freq_tx = txFreq_ops;
            radioB.Freq_rx = rxFreq_ops;
            // CH2
            radioB.CurrentChannel = RT1523.Channel.CH3;
            radioB.Freq_tx = txFreq_medic;
            radioB.Freq_rx = rxFreq_medic;

            // BFT
            bft.Overlays = routeOverlay;

        }

        // Settings for the radios on the retrans truck.
        private void SetupRetrans()
        {

            // radioA
            radioA.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioA.CurrentMode = RT1523.Mode.PT;
            // CH1
            radioA.CurrentChannel = RT1523.Channel.CH1;
            radioA.Freq_tx = txFreq_command;
            radioA.Freq_rx = rxFreq_ops;
            // CH2
            radioA.CurrentChannel = RT1523.Channel.CH2;
            radioA.Freq_tx = txFreq_medic;
            radioA.Freq_rx = rxFreq_ops;

            // radioB
            radioB.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioB.CurrentMode = RT1523.Mode.FHM;
            // CH1
            radioB.CurrentChannel = RT1523.Channel.CH1;
            radioB.Freq_tx = txFreq_ops;
            radioB.Freq_rx = rxFreq_command;

            // BFT
            bft.Overlays = routeOverlay;

        }

        // Settings for the radios on the medic truck.
        private void SetupMedicTruckRadios()
        {

            // radioA
            radioA.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioA.CurrentMode = RT1523.Mode.PT;
            // CH1
            radioA.CurrentChannel = RT1523.Channel.CH1;
            radioA.Freq_tx = txFreq_medic;
            radioA.Freq_rx = rxFreq_medic;

            // BFT
            bft.Overlays = routeOverlay;

        }

        // Settings for the radios on the spec ops truck.
        private void SetupSpecialForces()
        {

            // radioA
            radioA.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioA.CurrentMode = RT1523.Mode.FH;
            // CH1
            radioA.CurrentChannel = RT1523.Channel.CH1;
            radioA.Freq_tx = txFreq_special;
            radioA.Freq_rx = rxFreq_special;

            // radioB
            radioB.CurrentPower = RT1523.PowerSetting.VeryHigh;
            radioB.CurrentMode = RT1523.Mode.FHM;
            // CH1
            radioB.CurrentChannel = RT1523.Channel.CH1;
            radioB.Freq_tx = txFreq_ops;
            radioB.Freq_rx = rxFreq_ops;
            // CH2
            radioB.CurrentChannel = RT1523.Channel.CH2;
            radioB.Freq_tx = txFreq_medic;
            radioB.Freq_rx = rxFreq_medic;

            // sat
            satRadio.CurrentPower = ANPRC117.PowerSetting.VeryHigh;
            satRadio.CurrentMode = ANPRC117.Mode.FH;
            // CH1
            satRadio.CurrentChannel = ANPRC117.Channel.CH1;
            satRadio.Freq_tx = txFreq_sat;
            satRadio.Freq_rx = rxFreq_sat;

            // BFT
            bft.Overlays = routeOverlay;

        }

        // Determines which truck recives each type of radio.
        private void RadiosInTruckByType()
        {

            switch (truckType)
            {
                case TruckType.Medic:
                    radioA = new RT1523(3);
                    bft = new FBCB2(2, truckName);
                    break;
                case TruckType.Guntruck:
                case TruckType.Command:
                case TruckType.Retrans:
                    radioA = new RT1523(4);
                    radioB = new RT1523(5);
                    bft = new FBCB2(3, truckName);
                    break;
                case TruckType.Radio:
                case TruckType.SpecialForces:
                    radioA = new RT1523(6);
                    radioB = new RT1523(7);
                    satRadio = new ANPRC117(1);
                    bft = new FBCB2(4, truckName);
                    break;
            }

        }

    }
}
