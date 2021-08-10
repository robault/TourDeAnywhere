using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using Phidgets; 
using Phidgets.Events;
using WinAPI;

namespace TourDeAnywhere
{
    public partial class TourDeAnywhereForm : Form
    {
        #region Private Properties

        //Instantiate the Phidget interface kit
        private static InterfaceKit ifKit = new InterfaceKit();

        private static int _keydelay = 80;
        private static int _wheeldelay = 1000;
        private static int _joylow = 450;
        private static int _joyhigh = 550;
        private static int _wheellower = 450;
        private static int _wheelupper = 450;
        private static int _mph = 000;
        private static double _lastmeasure = 0;
        private static uint last = 0;
        private static bool isTripped = false;
        private static bool isRunning = false;
        private static bool isSuperSpeed = false;
        private static DateTime lastTripped;

        //sets the mid for the joysticks (range = 0 - 999)
        private static int sensorMidPoint = 450;
        private static int sensorFloatingPoint_UpDown = 450;
        private static int sensorFloatingPoint_LeftRight = 450;

        //forward movement detection
        private enum WheelSize
        {
            _16in,
            _18in,
            _20in,
            _22in,
            _24in,
            _650A,
            _650B,
            _650C,
            _26in,
            _700C,
            _27in
        }
        public System.Timers.Timer tmr = new System.Timers.Timer();
        private static int _elapsedTime = 1000;

        //left and right movement detection
        public System.Timers.Timer turn_tmr = new System.Timers.Timer();
        private static int _elapsedTimeLR = 10;

        //up and down movement detection
        public System.Timers.Timer vert_tmr = new System.Timers.Timer();
        private static int _elapsedTimeUD = 10;

        #endregion

        #region Private Methods

        private double CalculateMPH(WheelSize ws, double now, double last)
        {
            // rate = distance divided by time:
            // r=d/t

            //rate
            double mph = 0;

            //time
            double hr = (now - last) / 3600000; //convert milliseconds to hours

            //distance
            double dia = 0;

            //wheel diameter references
            //http://en.wikipedia.org/wiki/Bicycle_wheel
            //http://www.calculateme.com/Length/Inches/ToMiles.htm
            //http://www.calculateme.com/Length/Millimeters/ToMiles.htm

            switch (ws)
            {
                case WheelSize._16in:
                    {
                        dia = 0.0002525252525252525;
                    }
                    break;
                case WheelSize._18in:
                    {
                        dia = 0.0002840909090909091;
                    }
                    break;
                case WheelSize._20in:
                    {
                        dia = 0.0003156565656565657;
                    }
                    break;
                case WheelSize._22in:
                    {
                        dia = 0.00034722222222222223;
                    }
                    break;
                case WheelSize._24in:
                    {
                        dia = 0.0003787878787878788;
                    }
                    break;
                case WheelSize._26in:
                    {
                        dia = 0.00041035353535353534;
                    }
                    break;
                case WheelSize._27in:
                    {
                        dia = 0.0004261363636363636;
                    }
                    break;
                case WheelSize._650A:
                    {
                        dia = 0.00036660900342002706;
                    }
                    break;
                case WheelSize._650B:
                    {
                        dia = 0.000362880776266603;
                    }
                    break;
                case WheelSize._650C:
                    {
                        dia = 0.0003548029507675177;
                    }
                    break;
                case WheelSize._700C:
                    {
                        //dis = 0.00043495983456613376; //700mm
                        dia = 0.0004577020202020202; //29"
                        //wikipedia site says 29" inch are same as 700C (not 700mm)
                    }
                    break;
            }

            double radius = dia / 2;
            const double PI = 3.14159265358979323846;
            double circ;
            circ = 2 * PI * radius;

            //1 Mile = 63360 Inches
            //MessageBox.Show((circ * 63360).ToString());

            mph = (circ / hr);

            return mph;
        }

        private WheelSize GetWheelSize()
        {
            WheelSize configSize = WheelSize._700C;

            switch (wheelSizeComboBox.Text)
            {
                case "16in":
                    configSize = WheelSize._16in;
                    break;
                case "18in":
                    configSize = WheelSize._18in;
                    break;
                case "20in":
                    configSize = WheelSize._20in;
                    break;
                case "22in":
                    configSize = WheelSize._22in;
                    break;
                case "24in":
                    configSize = WheelSize._24in;
                    break;
                case "650A":
                    configSize = WheelSize._650A;
                    break;
                case "650B":
                    configSize = WheelSize._650B;
                    break;
                case "650C":
                    configSize = WheelSize._650C;
                    break;
                case "26in":
                    configSize = WheelSize._26in;
                    break;
                case "700C":
                    configSize = WheelSize._700C;
                    break;
                case "27in":
                    configSize = WheelSize._27in;
                    break;
            }

            return configSize;
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            SendInputs.VK myVK1 = (SendInputs.VK)Enum.Parse(typeof(SendInputs.VK), trigger1comboBox.SelectedItem.ToString());
            SendInputs.VK myVK2 = (SendInputs.VK)Enum.Parse(typeof(SendInputs.VK), trigger2comboBox.SelectedItem.ToString());

            //Crysis suit super speed
            SendInputs.VK myVK3 = (SendInputs.VK)Enum.Parse(typeof(SendInputs.VK), trigger3comboBox.SelectedItem.ToString());

            if (mphlabel.Text != "" && double.Parse(walkingNumericUpDown.Value.ToString()) < double.Parse(mphlabel.Text))
                SendInputs.KeyboardPress(myVK1);
            else
                SendInputs.KeyboardRelease(myVK1);

            if (mphlabel.Text != "" && double.Parse(runningNumericUpDown.Value.ToString()) < double.Parse(mphlabel.Text))
                SendInputs.KeyboardPress(myVK2);
            else
                SendInputs.KeyboardRelease(myVK2);

            if (mphlabel.Text != "" && double.Parse(maxSuitNumericUpDown.Value.ToString()) < double.Parse(mphlabel.Text))
            {
                if (isSuperSpeed == false) //set super speed
                {
                    //key press, hold long enough for the menu to display
                    SendInputs.KeyboardPress(myVK3);
                    System.Threading.Thread.Sleep(300); //enough time to display the menu

                    //set the foating position correctly
                    sensorFloatingPoint_UpDown = sensorFloatingPoint_UpDown + 100;

                    //move the mouse up to select super speed
                    WinAPI.MouseMove mm = new WinAPI.MouseMove();
                    mm.X = sensorFloatingPoint_LeftRight;
                    mm.Y = (999 - sensorFloatingPoint_UpDown);
                    SendInputs.MoveMouse(mm);
                    System.Threading.Thread.Sleep(300);

                    //release the key to select
                    SendInputs.KeyboardRelease(myVK3);

                    isSuperSpeed = true;
                }
            }
            else
            {
                if (isSuperSpeed == true)
                {
                    //key press, hold long enough for the menu to display
                    SendInputs.KeyboardPress(myVK3);
                    System.Threading.Thread.Sleep(300); //enough time to display the menu

                    //set the foating position correctly
                    sensorFloatingPoint_LeftRight = sensorFloatingPoint_LeftRight + 100;

                    //move the mouse up to select super speed
                    WinAPI.MouseMove mm = new WinAPI.MouseMove();
                    mm.X = sensorFloatingPoint_LeftRight;
                    mm.Y = (999 - sensorFloatingPoint_UpDown);
                    SendInputs.MoveMouse(mm);
                    System.Threading.Thread.Sleep(300);

                    //release the key to select
                    SendInputs.KeyboardRelease(myVK3);

                    isSuperSpeed = false;
                }
            }

            if (lastTripped.AddSeconds(3) < DateTime.Now)
            {
                //then it has been 3 seconds since the sensor was tripped
                mphlabel.Text = "0";
                tmr.Stop();
            }
        }

        private void turn_tmr_Elapsed(object sender, EventArgs e)
        {
            //calculate turn speed (num pixels to move)
            int pixels = 10;
            if (ifKit.sensors[7].Value > sensorMidPoint + 100)
            {
                pixels = (((ifKit.sensors[7].Value - sensorMidPoint) * 2) / 50);
            }
            else if (ifKit.sensors[7].Value < sensorMidPoint - 100)
            {
                pixels = (((sensorMidPoint - ifKit.sensors[7].Value) * 2) / 50);
            }

            //turn left and right
            if (ifKit.sensors[7].Value > sensorMidPoint + 100)
            {
                //go left
                sensorFloatingPoint_LeftRight = sensorFloatingPoint_LeftRight + (pixels);
                WinAPI.MouseMove mm = new WinAPI.MouseMove();
                mm.X = sensorFloatingPoint_LeftRight;
                mm.Y = (999 - sensorFloatingPoint_UpDown);
                SendInputs.MoveMouse(mm);
            }
            else if (ifKit.sensors[7].Value < sensorMidPoint - 100)
            {
                //go right
                sensorFloatingPoint_LeftRight = sensorFloatingPoint_LeftRight - (pixels);
                WinAPI.MouseMove mm = new WinAPI.MouseMove();
                mm.X = sensorFloatingPoint_LeftRight;
                mm.Y = (999 - sensorFloatingPoint_UpDown);
                SendInputs.MoveMouse(mm);
            }
            else
            {
                turn_tmr.Stop();
            }
        }

        private void vert_tmr_Elapsed(object sender, EventArgs e)
        {
            //calculate turn speed (num pixels to move)
            int pixels = 10;
            if (ifKit.sensors[6].Value > sensorMidPoint + 100)
            {
                pixels = (((ifKit.sensors[6].Value - sensorMidPoint) * 2) / 50);
            }
            else if (ifKit.sensors[6].Value < sensorMidPoint - 100)
            {
                pixels = (((sensorMidPoint - ifKit.sensors[6].Value) * 2) / 50);
            }

            //up and down
            if (ifKit.sensors[6].Value > sensorMidPoint + 100)
            {
                //go ?
                if (sensorFloatingPoint_UpDown < (999 - pixels)) //let's get a little bit of a buffer from 999
                {
                    sensorFloatingPoint_UpDown = sensorFloatingPoint_UpDown + (pixels);
                    WinAPI.MouseMove mm = new WinAPI.MouseMove();
                    mm.X = sensorFloatingPoint_LeftRight;
                    mm.Y = (999 - sensorFloatingPoint_UpDown); //inverted
                    SendInputs.MoveMouse(mm);
                }
            }
            else if (ifKit.sensors[6].Value < sensorMidPoint - 100)
            {
                //go ?
                if (sensorFloatingPoint_UpDown > (0 + pixels)) //let's get a little bit of a buffer from 0
                {
                    sensorFloatingPoint_UpDown = sensorFloatingPoint_UpDown - (pixels);
                    WinAPI.MouseMove mm = new WinAPI.MouseMove();
                    mm.X = sensorFloatingPoint_LeftRight;
                    mm.Y = (999 - sensorFloatingPoint_UpDown); //inverted
                    SendInputs.MoveMouse(mm);
                }
            }
            else
            {
                vert_tmr.Stop();
            }
        }

        #endregion

        #region Form Event Handlers

        private void startbutton_Click(object sender, EventArgs e)
        {
            tmr.Start();
            isRunning = true;
            statusLabel.Text = "Running";
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            turn_tmr.Stop();
            vert_tmr.Stop();

            isRunning = false;

            statusLabel.Text = "Stopped";
        }

        #endregion

        #region Interface Kit Methods

        //Interfacekit events
        protected void ifKit_Attach(object sender, AttachEventArgs e)
        {
            MessageBox.Show("Phidget Interface board: " + e.Device.Name + " is now attached.");
        }
        protected void ifKit_Detach(object sender, DetachEventArgs e)
        {
            MessageBox.Show("Phidget Interface board: " + e.Device.Name + " is now detached.");
        }
        protected void ifKit_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Description);
        }

        //jumping
        protected void ifKit_InputChange(object sender, InputChangeEventArgs e)
        {
            SendInputs.VK myVK1 = (SendInputs.VK)Enum.Parse(typeof(SendInputs.VK), jumpcomboBox.SelectedItem.ToString());

            if (ifKit.inputs[0] == true) //jump
            {
                SendInputs.KeyboardPress(myVK1);
                //bit of a hack here but you need a little delay for the keyboard 
                //message to be sent and picked up from the keyboard buffer, I always
                //feel like a Thread.Sleep is a hack... :)
                System.Threading.Thread.Sleep(_keydelay);
                SendInputs.KeyboardRelease(myVK1);
            }
        }

        //moving around
        protected void ifKit_SensorChange(object sender, SensorChangeEventArgs e)
        {
            switch (e.Index)
            {
                case 0: //Wheel sensor
                    {
                        sensoroutputlabel.Text = ifKit.sensors[0].Value.ToString();

                        //checking for and setting lowest and highest values
                        if (_wheellower > ifKit.sensors[0].Value)
                            _wheellower = ifKit.sensors[0].Value;
                        if (_wheelupper < ifKit.sensors[0].Value)
                            _wheelupper = ifKit.sensors[0].Value;

                        wheellowerlabel.Text = _wheellower.ToString();
                        wheelupperlabel.Text = _wheelupper.ToString();

                        //if the sensor is less than the (low point + some threshold value) then it's tripped
                        if (ifKit.sensors[0].Value > (_wheellower + sensorThresholdNumericUpDown.Value))
                        {
                            WheelSize ws = GetWheelSize();
                            uint now = Time.GetTime();
                            mphlabel.Text = CalculateMPH(ws, double.Parse(now.ToString()), double.Parse(last.ToString())).ToString("#.##");
                            last = now;
                            isTripped = false;
                            lastTripped = DateTime.Now;

                            //This keeps the sensor from being detected every other change. This 
                            // allows it to be detected once a revolution which makes our MPH
                            // calculation easier at higher RPMs. The sensor is only so sensitive.
                            //Detecting a change on once rev seems to make it more stable.
                        }
                    }
                    break;
                case 6: //Joystick Up and Down
                    {
                        if (ifKit.sensors[6].Value < _joylow || ifKit.sensors[6].Value > _joyhigh)
                        {
                            if (isRunning == true)
                            {
                                vert_tmr.Start();
                            }
                        }
                    }
                    break;
                case 7: //Joystick Left and Right
                    {
                        if (ifKit.sensors[7].Value < _joylow || ifKit.sensors[7].Value > _joyhigh)
                        {
                            if (isRunning == true)
                            {
                                turn_tmr.Start();
                            }
                        }
                    }
                    break;
            }
        }

        #endregion

        public TourDeAnywhereForm()
        {
            InitializeComponent();
        }

        private void TourDeAnywhereForm_Load(object sender, EventArgs e)
        {
            //Interface kit events
            ifKit.Attach += new AttachEventHandler(ifKit_Attach);
            ifKit.Detach += new DetachEventHandler(ifKit_Detach);
            ifKit.Error += new ErrorEventHandler(ifKit_Error);

            ifKit.InputChange += new InputChangeEventHandler(ifKit_InputChange);
            ifKit.SensorChange += new SensorChangeEventHandler(ifKit_SensorChange);

            //Listen for the USB connection
            ifKit.open();

            //Timer/SendInput
            tmr.Interval = _elapsedTime;
            tmr.Elapsed += Timer_Elapsed;

            //left right control timer
            turn_tmr.Interval = _elapsedTimeLR;
            turn_tmr.Elapsed += turn_tmr_Elapsed;

            //up down control timer
            vert_tmr.Interval = _elapsedTimeUD;
            vert_tmr.Elapsed += vert_tmr_Elapsed;

            //Set Defaults
            wheelSizeComboBox.SelectedText = "700C";
            trigger1comboBox.DataSource = Enum.GetValues(typeof(SendInputs.VK));
            trigger1comboBox.SelectedItem = SendInputs.VK.VK_W;
            trigger2comboBox.DataSource = Enum.GetValues(typeof(SendInputs.VK));
            trigger2comboBox.SelectedItem = SendInputs.VK.VK_LSHIFT;
            trigger3comboBox.DataSource = Enum.GetValues(typeof(SendInputs.VK));
            trigger3comboBox.SelectedItem = SendInputs.VK.VK_V;
            jumpcomboBox.DataSource = Enum.GetValues(typeof(SendInputs.VK));
            jumpcomboBox.SelectedItem = SendInputs.VK.VK_LCONTROL;
            walkingNumericUpDown.Value = 5;
            runningNumericUpDown.Value = 10;
            maxSuitNumericUpDown.Value = 15;

            //hack
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
