using System;

namespace FacadePattern
{
    class FBCB2
    {

        private string overlays;
        private string name;
        private int serialNumber;

        // Instantiation: This is the minimum requred information for the FBCB2.
        // It is overriden.
        public FBCB2(int serialNumber, string name)
        {

            this.serialNumber = serialNumber;
            this.name = name;

        }

        // Instantiation: This override adds the name to the FBCB2.
        public FBCB2(int serialNumber, string name, string overlays)
        {

            this.serialNumber = serialNumber;
            this.name = name;
            this.overlays = overlays;

        }

        // Getter Setter.
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Getter Setter. Is origianaly set to null.
        public string Overlays
        {
            get { return overlays; }
            set { overlays = value; }
        }

        // Displays the neccessary information about the FBCB2.
        public override string ToString()
        {

            string retVal = "State: ON\n";
            retVal += "Overlay: " + overlays + "\n";

            retVal.Replace("\n", Environment.NewLine);

            return retVal;

        }

    }
}
