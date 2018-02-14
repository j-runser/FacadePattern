using System;

namespace FacadePattern
{
    class Radio
    {
        
        public enum Mode { PT, FH, FHM };
        public enum PowerSetting { Low, Medium, High, VeryHigh };
        public enum FreqRange { VHF, UHF, HF, LF };
        public enum Channel { CH1, CH2, CH3, CH4, CH5, CH6, CH7, CH8, CH9, CH10 };

        private int minFreq;
        private int maxFreq;

        private int serialNumber;
        private string name;

        // Required settings for every radio.
        private Mode currentMode;
        private PowerSetting currentPower;
        private FreqRange freqRange;
        private int[] tx;
        private int[] rx;
        private int currentChannel;
        
        // Getter Setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Getter Setter
        public Mode CurrentMode
        {
            get { return currentMode; }
            set { currentMode = value; }
        }

        // Getter Setter
        public PowerSetting CurrentPower
        {
            get { return currentPower; }
            set { currentPower = value; }
        }

        // Getter Setter
        public int Freq_tx
        {
            get { return tx[currentChannel]; }
            set { tx[currentChannel] = value; }
        }

        // Getter Setter
        public int Freq_rx
        {
            get { return rx[currentChannel]; }
            set { rx[currentChannel] = value; }
        }

        // Getter Setter
        public Channel CurrentChannel
        {
            get { return (Channel)currentChannel; }
            set { currentChannel = (int)value; }
        }

        // The minimum settings required for a radio.
        protected void InitializeRadio(int serialNumber, FreqRange freqRange)
        {
            
            this.serialNumber = serialNumber;
            this.freqRange = freqRange;

            DetermineFreqRange(freqRange);

            currentPower = PowerSetting.Medium;
            currentChannel = (int)Channel.CH1;

            rx = new int[10];
            tx = new int[10];
            
        }

        // The frequency range of each radio. (These are not the real ones,
        // I can only show you the standards).
        private void DetermineFreqRange(FreqRange freqRange)
        {

            switch(freqRange)
            {
                case FreqRange.LF: minFreq = 40;  maxFreq = 300;   break;
                case FreqRange.HF: minFreq = 300; maxFreq = 30000; break;
                case FreqRange.VHF: minFreq = 30000; maxFreq = 300000; break;
                case FreqRange.UHF: minFreq = 300000; maxFreq = 3000000; break;
            }

        }

        // Provides the Display informatoin about the readio.
        public override string ToString()

        {

            string retVal = "";
            
            retVal += "Channel: CH" + (currentChannel + 1) + "\n";
            retVal += "Transmit: " + tx[currentChannel] + "\n";
            retVal += "Recive: " + rx[currentChannel] + "\n";

            switch(currentMode)
            {
                case Mode.FH:  retVal += "FH\n";  break;
                case Mode.FHM: retVal += "FHM\n"; break;
                case Mode.PT:  retVal += "PT\n";  break;
            }
            
            switch(currentPower)
            {
                case PowerSetting.Low:      retVal += "LOW\n";       break;
                case PowerSetting.Medium:   retVal += "MEDIUM\n";    break;
                case PowerSetting.High:     retVal += "HIGH\n";      break;
                case PowerSetting.VeryHigh: retVal += "VERY_HIGH\n"; break;
            }

            retVal = retVal.Replace("\n", Environment.NewLine);

            return retVal;

        }
        
    }
}
