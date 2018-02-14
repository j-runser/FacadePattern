namespace FacadePattern
{
    class RT1523 : Radio
    {

        const FreqRange FREQ_RANGE = FreqRange.LF;

        // Initializes to a radio with a specific FreqRange.s
        public RT1523(int serialNumber)
        {

            InitializeRadio(serialNumber, FREQ_RANGE);

        }


    }
}
