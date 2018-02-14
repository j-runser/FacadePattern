using System;
using System.Windows.Forms;

namespace FacadePattern
{
    public partial class Form1 : Form
    {

        Vehicle command;
        Vehicle ops;
        Vehicle commo;
        Vehicle spec;
        Vehicle medic;
        Vehicle rtns;

        string normalRoute;
        string specialRoute;
        string rtnsLoc;
        string unit;

        public Form1()
        {

            InitializeComponent();

            normalRoute = "Normal route";
            specialRoute = "Special route.";
            rtnsLoc = "Retransmit point";

            unit = "CAV-HQ-107-";
            resetRadios(unit);

            combo_vehicle.SelectedIndex = 0;
            combo_channel.SelectedIndex = 0;

            refreshText();

        }
        
        private void btn_setupCommand_Click(object sender, EventArgs e)
        {
            command.RouteOverlay = normalRoute;
            command.SetupRadios();
            refreshText();
        }

        private void btn_setupMedic_Click(object sender, EventArgs e)
        {
            medic.RouteOverlay = normalRoute;
            medic.SetupRadios();
            refreshText();
        }

        private void btn_setupCommo_Click(object sender, EventArgs e)
        {
            commo.RouteOverlay = normalRoute;
            commo.SetupRadios();
            refreshText();
        }

        private void btn_setupOps_Click(object sender, EventArgs e)
        {
            ops.RouteOverlay = specialRoute;
            ops.SetupRadios();
            refreshText();
        }

        private void btn_setupSpec_Click(object sender, EventArgs e)
        {
            spec.RouteOverlay = specialRoute;
            spec.SetupRadios();
            refreshText();
        }

        private void btn_setupRtns_Click(object sender, EventArgs e)
        {
            rtns.RouteOverlay = rtnsLoc;
            rtns.SetupRadios();
            refreshText();
        }

        private void btn_setupAll_Click(object sender, EventArgs e)
        {
            command.RouteOverlay = normalRoute;
            command.SetupRadios();
            medic.RouteOverlay = normalRoute;
            medic.SetupRadios();
            commo.RouteOverlay = normalRoute;
            commo.SetupRadios();
            ops.RouteOverlay = normalRoute;
            ops.SetupRadios();
            spec.RouteOverlay = specialRoute;
            spec.SetupRadios();
            rtns.RouteOverlay = rtnsLoc;
            rtns.SetupRadios();

            refreshText();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshText();
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            command.SetChannel((Radio.Channel)combo_channel.SelectedIndex);
            medic.SetChannel((Radio.Channel)combo_channel.SelectedIndex);
            commo.SetChannel((Radio.Channel)combo_channel.SelectedIndex);
            ops.SetChannel((Radio.Channel)combo_channel.SelectedIndex);
            spec.SetChannel((Radio.Channel)combo_channel.SelectedIndex);
            rtns.SetChannel((Radio.Channel)combo_channel.SelectedIndex);

            refreshText();

        }

        // Refreshing the text in the rich text feild.
        private void refreshText()
        {

            string tmp = "";

            switch(combo_vehicle.SelectedIndex)
            {
                case 0: tmp = command.ToString(); break;
                case 1: tmp = commo.ToString();   break;
                case 2: tmp = medic.ToString();   break;
                case 3: tmp = ops.ToString();     break;
                case 4: tmp = rtns.ToString();    break;
                case 5: tmp = spec.ToString();    break;
            }

            txtBox_display.Text = tmp;

        }

        private void resetRadios(string unit)
        {
            command = new Vehicle(Vehicle.TruckType.Command, unit + "S1");
            ops = new Vehicle(Vehicle.TruckType.Guntruck, unit + "S3");
            commo = new Vehicle(Vehicle.TruckType.Radio, unit + "S6");
            spec = new Vehicle(Vehicle.TruckType.SpecialForces, unit + "X");
            medic = new Vehicle(Vehicle.TruckType.Medic, unit + "MED");
            rtns = new Vehicle(Vehicle.TruckType.Retrans, unit + "RTNS");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            resetRadios(unit);
            refreshText();

        }
    }
}