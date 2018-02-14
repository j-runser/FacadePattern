namespace FacadePattern
{
    class ANPRC117 : Radio
    {

        const FreqRange FREQ_RANGE = FreqRange.VHF;

        // Setup the radio for the ANPRC117
        public ANPRC117(int serialNumber)
        {

            InitializeRadio(serialNumber, FREQ_RANGE);

        }

    }
}
