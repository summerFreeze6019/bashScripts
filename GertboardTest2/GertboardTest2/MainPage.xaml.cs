using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GertboardTest2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int BUTTON1 = 23;
        private int BUTTON2 = 24;
        private int BUTTON3 = 25;
        private int LED1 = 7;
        private int LED2 = 8;
        private int LED3 = 9;
        private GpioPin button1;
        private GpioPin button2;
        private GpioPin button3;
        private GpioPin led1;
        private GpioPin led2;
        private GpioPin led3;
        private GpioPinValue led1Value = GpioPinValue.Low;
        private GpioPinValue led2Value = GpioPinValue.Low;
        private GpioPinValue led3Value = GpioPinValue.Low;


        public MainPage()
        {
            this.InitializeComponent();
            InitGpio();

            button1.DebounceTimeout = TimeSpan.FromMilliseconds(50);
            button2.DebounceTimeout = TimeSpan.FromMilliseconds(50);
            button3.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            button1.ValueChanged += Button1_ValueChanged;
            button2.ValueChanged += Button2_ValueChanged;
            button3.ValueChanged += Button3_ValueChanged;
        }

        private void Button3_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs args)
        {
            if (args.Edge == GpioPinEdge.FallingEdge)
            {
                if (led3Value == GpioPinValue.Low)
                    led3Value = GpioPinValue.High;
                else
                    led3Value = GpioPinValue.Low;
                led3.Write(led3Value);
            }
        }

        private void Button2_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs args)
        {
            if (args.Edge == GpioPinEdge.FallingEdge)
            {
                if (led2Value == GpioPinValue.Low)
                    led2Value = GpioPinValue.High;
                else
                    led2Value = GpioPinValue.Low;
                led2.Write(led2Value);
            }
        }

        private void Button1_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs args)
        {
            if (args.Edge == GpioPinEdge.FallingEdge)
            {
                if (led1Value == GpioPinValue.Low)
                    led1Value = GpioPinValue.High;
                else
                    led1Value = GpioPinValue.Low;
                led1.Write(led1Value);

            }
        }

        private void InitGpio()
        {
            var gpio = GpioController.GetDefault();

            button1 = gpio.OpenPin(BUTTON1);
            button2 = gpio.OpenPin(BUTTON2);
            button3 = gpio.OpenPin(BUTTON3);
            led1 = gpio.OpenPin(LED1);
            led2 = gpio.OpenPin(LED2);
            led3 = gpio.OpenPin(LED3);

            led1.Write(GpioPinValue.Low);
            led1.SetDriveMode(GpioPinDriveMode.Output);

            led2.Write(GpioPinValue.Low);
            led2.SetDriveMode(GpioPinDriveMode.Output);

            led3.Write(GpioPinValue.Low);
            led3.SetDriveMode(GpioPinDriveMode.Output);

            if (button1.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                button1.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                button1.SetDriveMode(GpioPinDriveMode.Input);

            if (button2.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                button2.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                button2.SetDriveMode(GpioPinDriveMode.Input);

            if (button3.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                button3.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                button3.SetDriveMode(GpioPinDriveMode.Input);


        }
    }
}
